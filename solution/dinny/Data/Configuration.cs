using System.Configuration;
using NHibernate;
using NHibernate.Connection;
using NHibernate.Dialect;
using NHibernate.Tool.hbm2ddl;
using Environment = NHibernate.Cfg.Environment;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using FluentNHibernate.Mapping;
using FluentNHibernate.MappingModel;
using FluentNHibernate.Conventions;
using FluentNHibernate.Automapping;

namespace dinny.Core.Data
{
	public class Configuration : global::NHibernate.Cfg.Configuration
	{
		#region Singleton

        private static readonly object _locker = new object();

        private static FluentConfiguration _config;
		private static ISessionFactory _factory;

		/// <summary>
		/// Thread safe current NHibernate configuration
		/// </summary>
        public static FluentConfiguration Current
		{
			get
			{
				if (_config == null)
				{
					lock (_locker)
					{
						if (_config == null)
						{
							CreateConfiguration();
						}
					}
				}

				return _config;
			}
		}

		/// <summary>
		/// Create Configuration of NHibernate
		/// </summary>
		public static void ReConfigurate()
		{
			if (_config != null)
			{
				lock (_locker)
				{
					if (_config != null)
					{
						CreateConfiguration();
					}
				}
			}
		}

		private static void CreateConfiguration()
		{
            _config = Fluently.Configure()
                                        .Database(PostgreSQLConfiguration.Standard.ConnectionString(GetConnectionString()))
                                        .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Program>());
            _factory = _config
                            .ExposeConfiguration(config =>
                            {
                                config.SetProperty("show_sql", "false");
                                config.SetProperty("timeout", "600");
                            })
                            .BuildConfiguration().BuildSessionFactory();
		}

        /// <summary>
		/// Thread safe NHibernate Session Factory
		/// </summary>
		public static ISessionFactory Factory()
		{
			if (_factory == null)
			{
				lock (_locker)
				{
					if (_factory == null)
					{
						_factory = Current.BuildSessionFactory();
					}
				}
			}
			return _factory;			
		}

		#endregion

		private static string GetConnectionString()
		{
            return "server=localhost;Port=5432;Database=dinny;User Id=postgres;Password=1;";

		    //return new dbconfig.DataLayers.DbConfigFactory().GetConnectionStr();
		}
	}
}
