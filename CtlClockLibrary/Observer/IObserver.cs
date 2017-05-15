using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WatchPatterns
{
    public interface IObserver
    {
        void OnHandleEvent(TimeSpan time);
    }
}
