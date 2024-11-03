using System;
using System.Windows;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Waveify.Utilities;
using Waveify.Views;

namespace Waveify.ViewModel
{
    public class EditPlaylistVM : ViewModelBase
    {
        public ICommand SaveCommand { get; }

        public EditPlaylistVM()
        {
         
        }

        private void SavePlaylist()
        {
            // Логика сохранения изменений
            // Закрытие окна
        }
    }
}
