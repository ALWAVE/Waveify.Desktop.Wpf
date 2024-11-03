using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaveifyData.Data;
using NAudio.Wave;
using WaveifyData.Entities;
namespace Waveify.Events
{
    public class PlaylistBrowserChangedEventArgs : EventArgs
    {
        public int PlaylistId { get; set; }

        public PlaylistBrowserChangedEventArgs(int playlistId)
        {
            PlaylistId = playlistId;
        }
    }
}
