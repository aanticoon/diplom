using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using WinFormsApp1.Database;
using WinFormsApp1.Forms;
using WinFormsApp1.Logic;

namespace WinFormsApp1
{
	internal static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;

            Application.Run(ServiceProvider.GetRequiredService<AuthorizationForm>());
		}
        public static IServiceProvider ServiceProvider { get; private set; }
        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) => {
                    services.AddTransient<IAuthService, AuthService>();
                    services.AddTransient<IRepository, Repository>();
                    services.AddTransient<AuthorizationForm>();
                    services.AddTransient<MainForm>();
                });
        }
    }
}