using System;
using log4net;
using NHibernate;

namespace dinny.Core.Data
{
	/// <summary>
	/// Context for work with NHibernate Sessions
	/// </summary>
	public class DataContext : IDisposable
	{
		private static readonly ILog Log = Program.MainLog;

		/// <summary>
		/// Create new context and open session
		/// </summary>
		public DataContext()
		{
			OpenSession();
		}

		/// <summary>
		/// Create new context and open session
		/// </summary>
		/// <param name="fBeginTransaction">need to begin transaction</param>
		public DataContext(bool fBeginTransaction)
		{
			OpenSession();
			if (fBeginTransaction)
				BeginTransaction();
		}

        private ISession _session;
		private ITransaction _transaction;

		/// <summary>
		/// Return current session
		/// </summary>
		public ISession CurrentSession
		{
			get
			{
				try
				{
					OpenSession();
				}
				catch (HibernateException e)
				{
					Log.Error("Невозможно открыть сессию", e);
					throw;
				}

				return _session;
			}
		}

		/// <summary>
		/// Open session if not opened before
		/// </summary>
		public void OpenSession()
		{
			if (_session == null)
			{
                _session = Configuration.Factory().OpenSession();
			}
		}

		/// <summary>
		/// Close session if it opened
		/// </summary>
		public void CloseSession()
		{
			try
			{
				if (_session != null && _session.IsOpen)
				{
					_session.Close();
				}
				_session = null;
			}
			catch (HibernateException e)
			{
                Log.Error("Невозможно закрыть сессию", e);
				throw;
			}
		}

		/// <summary>
		/// Begin transaction if it not started before
		/// </summary>
		public void BeginTransaction()
		{
			try
			{
				if (_transaction == null)
				{
					_transaction = CurrentSession.BeginTransaction();
				}
			}
			catch (HibernateException e)
			{
                Log.Error("Невозможно открыть транзакцию", e);
				throw;
			}
		}

		/// <summary>
		/// Commit current transaction if it opened
		/// </summary>
		public void CommitTransaction()
		{
			try
			{
				if (_transaction != null && !_transaction.WasCommitted &&
					!_transaction.WasRolledBack)
				{
					_transaction.Commit();
				}
				_transaction = null;
			}
			catch (HibernateException e)
			{
                Log.Error("Невозможно подтвердить транзакцию", e);
				throw;
			}
		}

		/// <summary>
		/// Rollback current transaction
		/// </summary>
		public void RollbackTransaction()
		{
			try
			{
				if (_transaction != null && !_transaction.WasCommitted &&
					!_transaction.WasRolledBack)
					_transaction.Rollback();

				_transaction = null;
			}
			catch (HibernateException e)
			{
                Log.Error("Невозможно откатить транзакцию", e);
				throw;
			}
			finally
			{
				CloseSession();
			}
		}

		/// <summary>
		/// Commit transaction if requied and close session
		/// </summary>
		public void Dispose()
		{
			CommitTransaction();
			CloseSession();
		}
	}
}