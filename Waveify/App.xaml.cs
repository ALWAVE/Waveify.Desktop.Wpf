using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Win32;
using System;
using System.Data;
using System.IO;
using System.Windows;
using WaveifyData.Data;
using WaveifyData.Entities;

using Waveify.Extentsions;
using Waveify.Utilities;
using Waveify.ViewModel;
using Waveify.Pages;

namespace Waveify
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private IServiceProvider? _serviceProvider;
      
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
    
            Directory.CreateDirectory("data");
            // Инициализация сервисов
            IServiceCollection services = new ServiceCollection();
            _serviceProvider = services.AddViewModels()
                                       .AddNavigation()
                                       .AddDbContextFactory()
                                       .AddStores()
                                       .AddServices()
                                       .AddSingleton<MainWindow>() // Регистрация MainWindow
                                       .BuildServiceProvider();

            // Создание и миграция базы данных
            IDbContextFactory<DataContext> dbFactory = _serviceProvider.GetRequiredService<IDbContextFactory<DataContext>>();
     

            using (var dbContext = dbFactory.CreateDbContext())
            {
                dbContext.Database.Migrate();
            }
            var musicService = _serviceProvider.GetRequiredService<IMusicPlayerService>();
            if (e.Args.Length > 0)
            {
                string filePath = e.Args[0];

                if (File.Exists(filePath))
                {
                    HandleFileOpen(filePath, _serviceProvider.GetRequiredService<IMusicPlayerService>());
                }
                else
                {
                    Console.WriteLine("Файл не найден: " + filePath);
                }
            }
            MainWindow = _serviceProvider.GetRequiredService<MainWindow>();
            MainWindow.DataContext = _serviceProvider.GetRequiredService<MainVM>();
            MainWindow.Show();


        }
        private void HandleFileOpen(string filePath, IMusicPlayerService musicService)
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine("Файл не существует: " + filePath);
                return;
            }

            Console.WriteLine("Открытие файла: " + filePath);
            var media = new MediaEntity { FilePath = filePath };

            var dbFactory = _serviceProvider.GetRequiredService<IDbContextFactory<DataContext>>();
            using (var dbContext = dbFactory.CreateDbContext())
            {
                dbContext.Songs.Add(media);
                dbContext.SaveChanges();
            }

            musicService.Play(media.Id);
        }

    }
}
