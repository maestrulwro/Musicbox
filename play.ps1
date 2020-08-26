if(-not (Test-Path "Past")){
    md "Past"
	clear
	}
[int]$i= Read-Host -Prompt 'Number to start at'
DO
{
    if(Test-Path "$i"){
        ffplay.exe "$i" -autoexit
        copy "$i.info.json" "Past\$i.info.json"
        "copy successful"
        $i=$i+1
        "change successful: $i"
    }
    else
    {
        Start-Sleep -s 5
    }
} while ($TRUE)