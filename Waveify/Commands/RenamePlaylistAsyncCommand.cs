using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Waveify.Store;
using Waveify.Extentsions;
using Waveify.Model;
using Waveify.Utilities;
namespace Waveify.Commands
{
    public class RenamePlaylistAsyncCommand : AsyncCommandBase
    {
        private readonly PlaylistStore _playlistStore;
        private readonly PlaylistBrowserNavigationStore _playlistBrowserNavigationStore;

        public RenamePlaylistAsyncCommand(PlaylistStore playlistStore, PlaylistBrowserNavigationStore playlistBrowserNavigationStore)
        {
            _playlistStore = playlistStore;
            _playlistBrowserNavigationStore = playlistBrowserNavigationStore;
        }

        protected override async Task ExecuteAsync(object? parameter)
        {

            if (parameter is string playlistName)
            {
                await _playlistStore.Rename(_playlistBrowserNavigationStore.BrowserPlaylistId, playlistName);
            }
        }
    }
}
