using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

using MaterialDesignThemes.Wpf;


namespace Waveify.ViewModel
{
    public class ItemUserProfileVM
    {
        public ItemUserProfileVM(string header, List<SubItemVM> subItems, PackIconKind icon)
        {
            Header = header;
            SubItems = subItems;
            Icon = icon;
        }

        public ItemUserProfileVM(string header, UserControl screen, PackIconKind icon)
        {
            Header = header;
            Screen = screen;
            Icon = icon;
        }
        public string Header { get; private set; }
        public PackIconKind Icon { get; private set; }
        public List<SubItemVM> SubItems { get; private set; }
        public UserControl Screen { get; private set; }
    }
}
