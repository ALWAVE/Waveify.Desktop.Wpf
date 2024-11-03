using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Waveify.UI
{
    public interface IFilesDropAsync
    {
        Task OnFilesDroppedAsync(string[] files, object? parameter);
    }
}
