﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Waveify.Store;
using System.Threading.Tasks;
using Waveify.Extentsions;
using Waveify.Model;
using Waveify.Utilities;
using WaveifyData.Entities;
using NAudio.Wave;
using System.Threading.Tasks;

namespace Waveify.Commands
{
    public class CreatePlaylistAsyncCommand : AsyncCommandBase
    {
        private readonly PlaylistStore _playlistStore;
        private readonly ObservableCollection<PlaylistModel>? _observablePlaylists;
        public CreatePlaylistAsyncCommand(PlaylistStore playlistStore)
        {
            _playlistStore = playlistStore;
        }

        public CreatePlaylistAsyncCommand(PlaylistStore playlistStore, ObservableCollection<PlaylistModel> observablePlaylists) : this(playlistStore)
        {
            _observablePlaylists = observablePlaylists;
        }

        protected override async Task ExecuteAsync(object? parameter)
        {
            var playlistId = _playlistStore.Playlists.Count() + 1;

            var playlist = new PlaylistEntity
            {
                Name = $"My Playlist #{playlistId}",
                CreationDate = DateTime.Now
            };

            await _playlistStore.Add(playlist);

            _observablePlaylists?.Insert(0, new PlaylistModel
            {
                Id = playlist.Id,
                Name = playlist.Name,
                CreationDate = playlist.CreationDate
            });
        }
    }
}
