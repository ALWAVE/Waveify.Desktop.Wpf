using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.DependencyInjection;
using Waveify.Utilities;
using Waveify.Store;
using Waveify.ViewModel;
using WaveifyData.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Waveify.Extentsions
{
    public static class ServiceContainerExtensions
    {
        public static IServiceCollection AddViewModels(this IServiceCollection collection)
        {
            collection.AddTransient<HomeVM>();
            collection.AddTransient<PlaylistVM>();
            collection.AddTransient<DownloadsVM>();
            collection.AddSingleton<PlayerVM>();
            collection.AddSingleton<ToolbarVM>();
            collection.AddSingleton<MainVM>();
            collection.AddTransient<MyFileVM>();
            collection.AddTransient<SettingVM>();
            collection.AddTransient<ProfileVM>();
            return collection;
        }

        public static IServiceCollection AddStores(this IServiceCollection collection)
        {
            collection.AddSingleton<MediaStore>();
            collection.AddSingleton<PlaylistStore>();
            collection.AddSingleton<PlaylistBrowserNavigationStore>();
            return collection;
        }

        public static IServiceCollection AddNavigation(this IServiceCollection collection)
        {
            collection.AddTransient<INavigationService>(s =>
                new NavigationService(
                    () => s.GetRequiredService<MainVM>(),
                    () => s.GetRequiredService<HomeVM>(),
                    () => s.GetRequiredService<PlaylistVM>(),
                    () => s.GetRequiredService<DownloadsVM>(),
                    () => s.GetRequiredService<MyFileVM>(), 
                    () => s.GetRequiredService<SettingVM>(),
                    () => s.GetRequiredService<ProfileVM>()

            ));

            return collection;
        }

        public static IServiceCollection AddServices(this IServiceCollection collection)
        {
            collection.AddSingleton<IMusicPlayerService, MusicPlayerService>();
            collection.AddSingleton<IYouTubeClientService, YouTubeClientService>();
            return collection;
        }

        public static IServiceCollection AddDbContextFactory(this IServiceCollection collection)
        {
            collection.AddDbContextFactory<DataContext>();
            return collection;
        }
    }
}
