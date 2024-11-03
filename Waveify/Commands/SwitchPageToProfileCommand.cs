﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Waveify.Store;
using Waveify.Utilities;

namespace Waveify.Commands
{
    public class SwitchPageToProfileCommand : CommandBase
    {
        private readonly INavigationService _navigationService;

        private readonly PlaylistBrowserNavigationStore _playlistBrowserNav;
        public SwitchPageToProfileCommand(INavigationService navigationService, PlaylistBrowserNavigationStore playlistBrowserNav)
        {
            _navigationService = navigationService;
            _playlistBrowserNav = playlistBrowserNav;
        }

        public override void Execute(object? parameter)
        {
            _playlistBrowserNav.BrowserPlaylistId = 0;
            _navigationService.NavigateProfile();
        }
    }
}
