# TorrentFlow
A tool for simplifying the process of downloading torrents, managing a seedbox, fetching medatadata, and updating media center libraries.

##What?
For a significant amount of folks, updating an HTPC (that's Home Theater PC for you muggles) with new content can be a painful process that looks something like this:

1. Download the .torrent file from a torrent tracker site.
2. Upload the .torrent file to a seedbox.
3. Wait for the files to download onto the seedbox.
4. Download the files from the seedbox to the HTPC.
5. Restructure the folders and/or rename the files to fit a metadata scraper.
6. Embed metadata in/around the files using a metadata program.
7. Update the HTPC's media center library.

As a developer who's slightly more bored than I am lazy, TorrentFlow is my attempt to reduce this process to one step:

1. Download the .torrent file from a torret tracker site and let TorrentFlow handle the rest. If anything unexpected happens, notify me and offer solutions.

While I'm doing my best to keep TorrentFlow flexible, my top priority is, well, my personal setup. This consists of the following:

* Multiple computers and Android devices from which I browse trackers.
* A seedbox running ruTorrent.
* [Kodi](http://kodi.tv/) as my HTPC media center.

##Roadmap
These are the features I'd like to implement:

 - [x] Automatically upload .torrent files from the HTPC to the seedbox and begin downloading them.
 - [ ] Automatically upload .torrent files from other devices to the seedbox and begin downloading them.
 - [ ] Automatically download completed files from the seedbox to the HTPC.
 - [ ] Automatically rename or restructure movie and TV show files as necessary.
 - [ ] Automatically fetch metadata for movies and TV shows.
  - [ ] If the movie or show cannot be deteremined, notify the owner and offer solutions.
 - [ ] Automatically update the media center's library.
 
##Instructions
Clone the repo and open the solution file in Visual Studio. Be sure to open up the settings (right click on the icon->"Settings...") before you try anything.

##Sounds great, but it'd be even better if it could do backflips!
Feel free to submit a pull request!

##Your code sucks
Fix it and submit a pull request!
