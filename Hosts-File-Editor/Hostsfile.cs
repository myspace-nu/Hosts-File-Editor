using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class Host
{
    public string Hostname { get; set; }
    public string IP { get; set; }
    public string Comment { get; set; }
    public bool Active { get; set; }
    public Host(string hostname, string ip, string comment = "", bool active = true)
    {
        Hostname = hostname;
        IP = ip;
        Comment = comment;
        Active = active;
    }
}
class Hostsfile
{
    public string Header { get; set; }
    public string Filename { get; set; }
    public List<Host> Hosts = new List<Host> { };
    public Hostsfile()
    {

    }
    public Hostsfile fromFile(string filename = @"C:\Windows\System32\drivers\etc\hosts")
    {
        Hostsfile hf = new Hostsfile();
        hf.Filename = filename;
        bool header = true;
        foreach (var line in File.ReadLines(Environment.ExpandEnvironmentVariables(filename)))
        {
            if (header && line.StartsWith("#"))
            {
                hf.Header += line + Environment.NewLine;
            }
            else
            {
                header = false;
                if (Regex.IsMatch(line, @"\d+\.\d+\.\d+\.\d+"))
                {
                    Match match = Regex.Match(line, @"^(\#*)\s*(\d+\.\d+\.\d+\.\d+)\s+([\w\.\-]+)\s*\#{0,1}([\w\W]*)$");
                    if (!string.IsNullOrEmpty(match.Groups[2].Value) && !string.IsNullOrEmpty(match.Groups[3].Value))
                    {
                        hf.Hosts.Add(new Host(
                            match.Groups[3].Value,
                            match.Groups[2].Value,
                            (string.IsNullOrEmpty(match.Groups[4].Value)) ? "" : match.Groups[4].Value,
                            string.IsNullOrEmpty(match.Groups[1].Value)
                            ));
                    }
                }
            }
        }
        return hf;
    }
    public bool writeToFile(string filename = "")
    {
        if(!string.IsNullOrEmpty(filename))
        {
            this.Filename = filename;
        }
        string content = this.Header + Environment.NewLine;
        for (var i = 0; i < this.Hosts.Count; i++)
        {
            content += (
                    ((this.Hosts[i].Active) ? "" : "# ") +
                    this.Hosts[i].IP
                ).PadRight(25) +
                this.Hosts[i].Hostname.PadRight(25) +
                ((string.IsNullOrEmpty(this.Hosts[i].Comment)) ? "" : " #" + this.Hosts[i].Comment) +
                Environment.NewLine;
        }
        File.WriteAllText(Environment.ExpandEnvironmentVariables(this.Filename), content);
        return true;
    }
}
