
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Waveify.Events;
using Waveify.Enums;
using Waveify.ViewModel;
using System;
namespace Waveify.Utilities
{
    public interface INavigationService
    {
        public event EventHandler<PageChangedEventArgs> PageChangedEvent;
        public NavigationEN CurrentPage { get; }
        public void NavigateHome();
        public void NavigatePlaylist();
        public void NavigateDownloads();
        public void NavigateMyFile();
        public void NavigateSettings();
        public void NavigateProfile();
    }

    public class NavigationService : INavigationService
    {
        private readonly Func<MainVM>? _mainViewModelFunc;
        private readonly Func<HomeVM>? _homeViewModelFunc;
        private readonly Func<PlaylistVM>? _playlistViewModelFunc;
        private readonly Func<DownloadsVM>? _downloadViewModelFunc;
        private readonly Func<MyFileVM>? _myFileViewModelFunc;
        private readonly Func<SettingVM> _settingViewModelFunc;
        private readonly Func<ProfileVM> _profileViewModelFunc;

        public event EventHandler<PageChangedEventArgs>? PageChangedEvent;
        public NavigationEN CurrentPage { get; private set; } = NavigationEN.Home;

        public NavigationService(Func<MainVM> mainViewModelFunc, Func<HomeVM> homeViewModelFunc,
                                 Func<PlaylistVM> playlistViewModelFunc, Func<DownloadsVM> downloadViewModelFunc, Func<MyFileVM> myFileViewModelFunc, Func<SettingVM> settingViewModelFunc, Func<ProfileVM> profileViewModelFunc)
        {
            _mainViewModelFunc = mainViewModelFunc;
            _homeViewModelFunc = homeViewModelFunc;
            _playlistViewModelFunc = playlistViewModelFunc;
            _downloadViewModelFunc = downloadViewModelFunc;
            _myFileViewModelFunc = myFileViewModelFunc;
            _settingViewModelFunc = settingViewModelFunc;
            _profileViewModelFunc = profileViewModelFunc;
        }

        public void NavigateHome()
        {
            var mainVm = _mainViewModelFunc?.Invoke();
            var homeVm = _homeViewModelFunc?.Invoke();

            if (mainVm != null && mainVm.CurrentView is not HomeVM)
            {
                mainVm.CurrentView = homeVm;
                CurrentPage = NavigationEN.Home;
                PageChangedEvent?.Invoke(this, new PageChangedEventArgs(CurrentPage));
            }
        }

        public void NavigatePlaylist()
        {
            var mainVm = _mainViewModelFunc?.Invoke();
            var playlistVm = _playlistViewModelFunc?.Invoke();

            if (mainVm != null)
            {
                mainVm.CurrentView = playlistVm;
                CurrentPage = NavigationEN.Playlist;
                PageChangedEvent?.Invoke(this, new PageChangedEventArgs(CurrentPage));
            }
        }
        public void NavigateDownloads()
        {
            var mainVm = _mainViewModelFunc?.Invoke();
            var downloadsVm = _downloadViewModelFunc?.Invoke();

            if (mainVm != null && mainVm.CurrentView is not DownloadsVM)
            {
                mainVm.CurrentView = downloadsVm;
                CurrentPage = NavigationEN.Downloads;
                PageChangedEvent?.Invoke(this, new PageChangedEventArgs(CurrentPage));
            }
        }

        public void NavigateMyFile()
        {
            var mainVm = _mainViewModelFunc?.Invoke();
            var myfileVm = _myFileViewModelFunc?.Invoke();

            if (mainVm != null && mainVm.CurrentView is not MyFileVM)
            {
                mainVm.CurrentView = myfileVm;
                CurrentPage = NavigationEN.MyFile;
                PageChangedEvent?.Invoke(this, new PageChangedEventArgs(CurrentPage));
            }
        }
        public void NavigateSettings()
        {
            var mainVm = _mainViewModelFunc?.Invoke();
            var settingsVm = _settingViewModelFunc?.Invoke();

            if (mainVm != null && mainVm.CurrentView is not SettingVM)
            {
                mainVm.CurrentView = settingsVm;
                CurrentPage = NavigationEN.Settings;
                PageChangedEvent?.Invoke(this, new PageChangedEventArgs(CurrentPage));
            }
        }
        public void NavigateProfile()
        {
            var mainVm = _mainViewModelFunc?.Invoke();
            var profileVm = _profileViewModelFunc?.Invoke();

            if (mainVm != null && mainVm.CurrentView is not ProfileVM)
            {
                mainVm.CurrentView = profileVm;
                CurrentPage = NavigationEN.Profile;
                PageChangedEvent?.Invoke(this, new PageChangedEventArgs(CurrentPage));
            }
        }
    }
}
