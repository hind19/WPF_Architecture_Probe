using BLL_Services;
using CleanArchWPF.Profiles;
using DB_Repo;
using Dispatcher;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Repo_Dispatcher_Contracts;
using System.Windows;

namespace CleanArchWPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static IHost? AppHost { get; private set; }

        public App()
        {

            AppHost = Host.CreateDefaultBuilder()
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddSingleton<MainWindow>();
                    services.AddTransient<IUiOperator, UiOperator>();
                    services.AddTransient<ITaskProcessor, TaskProcessor>();
                    services.AddTransient<IRepositoryOperator, RepositoryOperator>();
                    services.AddAutoMapper(typeof(AppMappingProfile));
                })
                .Build();
        }

        protected override async void OnStartup(StartupEventArgs e)
        {
            await AppHost!.StartAsync();
            var mainWindow = AppHost.Services.GetRequiredService<MainWindow>();
            
            mainWindow.Show();
            base.OnStartup(e);
        }

        protected override async void OnExit(ExitEventArgs e)
        {
            await AppHost!.StopAsync();
            base.OnExit(e);
        }
    }

}
