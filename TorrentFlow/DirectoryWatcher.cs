using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorrentFlow
{
    class DirectoryWatcher
    {
        private readonly FileSystemWatcher watcher;
        public DirectoryWatcher(string watchDirectory, Action<object, FileSystemEventArgs> createdHandler, NotifyFilters notifyFilters)
        {
            if (Directory.Exists(watchDirectory)){
                watcher = new FileSystemWatcher(watchDirectory);
                watcher.NotifyFilter = notifyFilters;
                watcher.Created += new FileSystemEventHandler(createdHandler);
            } else
            {
                throw new Exception("Directory does not exist!");
            }

        }

        public void SetFilter(string filter) {
            watcher.Filter = filter;
        }

        public void Start()
        {
            watcher.EnableRaisingEvents = true;
        }

        public void Pause()
        {
            watcher.EnableRaisingEvents = false;
        }
    }
}
