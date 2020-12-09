Invoke-WebRequest -Uri https://yt-dl.org/latest/youtube-dl.exe -OutFile youtube-dl.exe
Invoke-WebRequest -uri https://www.gyan.dev/ffmpeg/builds/ffmpeg-release-essentials.zip -OutFile ffmpeg.zip
Expand-Archive .\ffmpeg.zip
move .\ffmpeg\ffmpeg-*\bin\ffplay.exe ffplay.exe
Remove-Item .\ffmpeg\ -recurse
Remove-Item .\ffmpeg.zip -recurse
