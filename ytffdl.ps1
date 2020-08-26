Invoke-WebRequest -Uri https://yt-dl.org/latest/youtube-dl.exe -OutFile youtube-dl.exe
Invoke-WebRequest -uri https://ffmpeg.zeranoe.com/builds/win64/static/ffmpeg-4.3.1-win64-static.zip -OutFile ffmpeg.zip
Expand-Archive .\ffmpeg.zip
xcopy \ffmpeg\ffmpeg-4.3.1-win64-static\bin\ffplay.exe ffplay.exe
echo F|xcopy.exe .\ffmpeg\ffmpeg-4.3.1-win64-static\bin\ffplay.exe ffplay.exe
Remove-Item .\ffmpeg\ -recurse
Remove-Item .\ffmpeg.zip -recurse