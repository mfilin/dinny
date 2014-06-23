using System;
using System.Globalization;
using System.Windows.Forms;
using dinny.Core.Data;
using dinny.Forms;
using log4net;

namespace dinny
{
    public class Program
    {
        public static readonly ILog MainLog = LogManager.GetLogger(typeof(Program));
        public static readonly CultureInfo Culture = new CultureInfo("en-US"); 

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Configuration.ReConfigurate();
                var dataContext = new DataContext();
            }
            catch (Exception exp)
            {
                const string lcError = "Нет соединения с сервером";
                MessageBox.Show(lcError);
                MainLog.Error(lcError);
            }
            MainLog.Info("запуск приложения");
            Application.Run(new frmMain());
            MainLog.Info("выход из приложения");
        }
    }
}
