﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Waveify.Utilities;

namespace Waveify.Commands
{
    public class ForwardSongCommand : CommandBase
    {
        private readonly IMusicPlayerService _musicService;
        public ForwardSongCommand(IMusicPlayerService musicService)
        {
            _musicService = musicService;
        }

        public override void Execute(object? parameter)
        {
            _musicService.PlayNext();
        }
    }
}
