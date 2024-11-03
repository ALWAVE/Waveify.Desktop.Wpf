using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
namespace Waveify.ViewModel
{
    public class SubItemVM
    {
        public SubItemVM(string name, UserControl screen = null) 
        {
            Name = name;
            Screen = screen;

        }
        private string Name { get; set; }
        private UserControl Screen { get; set; }

    }
}
