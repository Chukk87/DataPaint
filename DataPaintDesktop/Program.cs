using System;
using System.Windows.Forms;
using DataPaintLibrary.Services.Interfaces;
using DataPaintLibrary.Services.Classes;
using Microsoft.Extensions.DependencyInjection;

namespace DataPaintDesktop
{
    static class Program
    {
        // Create a service provider
        public static IServiceProvider ServiceProvider { get; private set; }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Configure the service collection for DI
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);

            // Build the service provider
            ServiceProvider = serviceCollection.BuildServiceProvider();

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(ServiceProvider.GetService<Home>());
        }

        // Change the parameter type to IServiceCollection instead of ServiceCollection
        private static void ConfigureServices(IServiceCollection services)
        {
            // Register services here
            services.AddSingleton<ILoggerService, LoggerService>();
            services.AddSingleton<ISqlService, SqlService>();
            services.AddSingleton<IAppCollectionService, AppCollectionService>();
            services.AddSingleton<IDataExtractionService, DataExtractionService>();
            services.AddSingleton<IClassBuilderService, ClassBuilderService>();
            services.AddSingleton<IOrchestratorService, OrchestratorService>();
            services.AddSingleton<ISecurityGroupService, SecurityGroupService>();

            // Register forms, allowing DI to inject dependencies into them
            services.AddTransient<Home>();
            services.AddTransient<ManageGroupOwner>();
        }
    }
}
