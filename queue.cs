using System;
using System.Collections.Generic;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System;
using System.IO;

class AddURL
{
    public static void Main()
    {
        string link = "";
        string srv = "";
        string query = System.Environment.GetEnvironmentVariable("QUERY_STRING");
        string[] query_part = query.Split(new char[] { '&', '=', '?' });
        for (int i = 0; i < query_part.Length - 1; i = i + 2)
        {
            if (query_part[i] == "lnk") link = System.Net.WebUtility.UrlDecode(query_part[i + 1]);
            if (query_part[i] == "srv") srv = System.Net.WebUtility.UrlDecode(query_part[i + 1]);
        }
        Console.WriteLine("Content-Type:text/html\n");
        Console.WriteLine("<html><body>");
	Console.WriteLine(Environment.CurrentDirectory);
        Console.WriteLine("ttl=" + query + "<br/>");
        Console.WriteLine("lnk=" + link + "<br/>");
        Console.WriteLine("srv=" + srv + "<br/>");
        int j = 1;
        while (File.Exists(j.ToString()))
            j++;
        Console.WriteLine("</body></html>");
        Process YTDLInstance = new Process()
        {
            EnableRaisingEvents = true,
            StartInfo = new ProcessStartInfo()
            {
                FileName = @"youtube-dl.exe",
                Arguments = "--no-playlist " + link + " -f " + "bestaudio" + @" -o """ + (j.ToString()) + @""" --write-info-json",
                RedirectStandardError = true,
                RedirectStandardInput = true,
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            }
        };
        YTDLInstance.OutputDataReceived += YTDLInstance_DataReceived;
        YTDLInstance.ErrorDataReceived += YTDLInstance_DataReceived;
        YTDLInstance.Start();
        YTDLInstance.BeginOutputReadLine();
        YTDLInstance.BeginErrorReadLine();
        YTDLInstance.WaitForExit();
        Console.WriteLine("Finished download.");
        string ff = @""""  + j + @"""";
        Console.WriteLine(@"<audio controls><source src="+ff+"></audio>");
    }

    private static void YTDLInstance_DataReceived(object sender, DataReceivedEventArgs e)
    {
        if (e != null)
            if (!string.IsNullOrWhiteSpace(e.Data))
                Console.WriteLine("<i>"+e.Data+"</i><br/>");
    }
}