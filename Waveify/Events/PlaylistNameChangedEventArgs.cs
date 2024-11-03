using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Waveify.Events
{
    public class PlaylistNameChangedEventArgs : EventArgs
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public PlaylistNameChangedEventArgs(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
