using System;
using System.IO;

namespace TorrentFlow
{
    class DirectoryWatcher
    {
        private readonly FileSystemWatcher watcher;
        public DirectoryWatcher(string watchDirectory, Action<object, FileSystemEventArgs> handler, NotifyFilters notifyFilters)
        {
            if (Directory.Exists(watchDirectory)){
                watcher = new FileSystemWatcher(watchDirectory);
                watcher.NotifyFilter = notifyFilters;
                watcher.Created += new FileSystemEventHandler(handler);
                watcher.Changed += new FileSystemEventHandler(handler);

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
