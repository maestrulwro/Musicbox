# Musicbox
A co-op DJ'ing platform.
This small project is meant to enable everyone to quickly install a web server that others can go to and add music in queue. For exemplification only, and in no way wanting to break any TOC's or copyrights, we provide a mechanism through which the "server" can play all the queued music (using youtube-dl and FFmpeg).

(C) Vlad-Florin Chelaru, 26.08.2020, Bacău, România; Using GNU AFFERO GENERAL PUBLIC LICENSE
This is created so that it can be run with ISS. Please install the following via Control Panel - Turn Windows features on or off:
Internet Information Services
+Web Management Tools
++IIS Management Console
++IIS Management Service
+World Wide Web Services
++App Dev Features
+++CGI
++Common HTTP Features
etc...

I provide a precompiled queue.exe, but you can compile it from queue.cs using compile_cs.ps1. PLEASE recompile it.
In order for all this to work, you will need to do some of the following:
-Add and configure website in IIS interface
-provide IUSR user access to the folder where Musicbox is "installed"
-set default document to index.htm
-configure CGI and ISAPI-CGI restrictions in IIS
-enable CGI handler in website
-create virtual folder called CGI
-create a MIME type for *.* files of type application/octet-stream

If configuring CGI proves hard, some of those links might be of help:
https://docs.microsoft.com/en-us/iis/configuration/system.webserver/cgi
https://blogs.iis.net/thomad/how-to-run-a-cgi-program-under-iis-7-0-or-iis-7-5
https://serverfault.com/questions/478390/setup-cgi-exe-in-iis-7-will-always-download-as-exe-file-instead-of-executing
https://stackoverflow.com/questions/60217677/setting-iis-to-execute-exe-instead-of-downloading

And most importantly, download and unpack:
-youtube-dl.exe https://yt-dl.org/latest/youtube-dl.exe
-ffplay.exe part of ffmpeg executables https://ffmpeg.zeranoe.com/builds/win64/static/ffmpeg-4.3.1-win64-static.zip
Those can be automatically downloaded by the script ytffdl.ps1!

If all is well, you should be able to see the website on localhost. Run play.ps1 to listen to the audio tracks that the users submit via web interface.

Send thanks or problems to vladflorinchelaru@gmail.com!
