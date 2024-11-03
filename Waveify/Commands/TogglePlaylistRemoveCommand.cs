using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Waveify.ViewModel;

namespace Waveify.Commands
{
    public class TogglePlaylistRemoveCommand : CommandBase
    {
        private readonly ToolbarVM _toolbar;
        public TogglePlaylistRemoveCommand(ToolbarVM toolbar)
        {
            _toolbar = toolbar;
        }

        public override void Execute(object? parameter)
        {
            _toolbar.IsRemoveActive = !_toolbar.IsRemoveActive;
        }
    }
}
