using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Waveify.ViewModel;
using NAudio.Wave;
using Waveify.Utilities;


namespace Waveify.Commands
{
    public class ToggleVolumeCommand : CommandBase
    {
        private readonly PlayerVM _player;
        private int _volume;
        public ToggleVolumeCommand(PlayerVM player)
        {
            _player = player;
        }

        public override void Execute(object? parameter)
        {
            if (parameter is int volume)
            {
                if (volume == 0)
                {
                    _player.Volume = _volume;
                }
                else
                {
                    _volume = _player.Volume;
                    _player.Volume = 0;
                }
            }
        }
    }
}
