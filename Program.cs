using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using System.Configuration;
namespace AkNotes
{
    internal static class Program
    {
        public static IConfiguration? Configuration { get; private set; }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Con esta sentencia se permite que se pueda hacer las consultas a las llaves privadas de appsettings.json y para poder manipularlas
            var builder = new ConfigurationBuilder().SetBasePath(AppDomain.CurrentDomain.BaseDirectory).AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            Configuration = builder.Build();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}