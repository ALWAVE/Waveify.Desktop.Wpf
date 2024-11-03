using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Waveify.Enums;
using WaveifyData.Entities;
namespace Waveify.Events
{
    public class PageChangedEventArgs : EventArgs
    {
        public NavigationEN Page { get; set; }

        public PageChangedEventArgs(NavigationEN page)
        {
            Page = page;
        }
    }
}
