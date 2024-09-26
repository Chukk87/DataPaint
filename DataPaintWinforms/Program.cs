using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using DataPaintLibrary;

namespace DataPaintWinforms
{
    static class Program
    {
        // Create a service provider
        public static IServiceProvider ServiceProvider { get; private set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Configure the service collection for DI
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);

            // Build the service provider
            ServiceProvider = serviceCollection.BuildServiceProvider();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Resolve HomeForm from DI container and run it
            var homeForm = ServiceProvider.GetRequiredService<HomeForm>();
            Application.Run(homeForm);
        }

        // Change the parameter type to IServiceCollection instead of ServiceCollection
        private static void ConfigureServices(IServiceCollection services)
        {
            // Register your services here
            services.AddScoped<IDataExtraction, DataExtraction>();

            // Register your forms, allowing DI to inject dependencies into them
            services.AddTransient<HomeForm>();
        }
    }
}   
