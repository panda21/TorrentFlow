using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TorrentFlow
{
    public class ProcessIcon : IDisposable
    {
        NotifyIcon ni;
        public ProcessIcon(string name)
        {
            ni = new NotifyIcon();
            ni.Text = name;
            ni.Icon = TorrentFlow.Properties.Resources.icon;
        }
        public void Display()
        {
            ni.Visible = true;
        }
        public void Dispose()
        {
            ni.Dispose();
        }

        public void SetContextMenuStrip(ContextMenuStrip menu)
        {
            ni.ContextMenuStrip = menu;
        }

        public void Notify(string title, string text, int duration)
        {
            ni.ShowBalloonTip(duration, title, text, new ToolTipIcon());
        }
    }
}