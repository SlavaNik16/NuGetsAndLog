using Serilog;
using System;
using System.Windows.Forms;

namespace FormsLoging
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var assembly = System.Reflection.Assembly.GetCallingAssembly();
            var version = assembly.GetName().Version.ToString();
            Log.Logger = new LoggerConfiguration()

                .Enrich.WithProperty("Version", version)
                .WriteTo.File("log-.txt", rollingInterval: RollingInterval.Day,outputTemplate:
              "{Timestamp:yyyy:MM:dd HH:mm} [{Level}] №[{Version}] {Message}{NewLine}{Exception}").CreateLogger();
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
