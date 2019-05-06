using System;
using System.Diagnostics;
using System.IO;
namespace Team_Agile
{
    public class Php
    {

        public Php() {
            

        }
        public string Excute(string command)
        {
            Process process = GetProcess(command);
            process.Start();
            process.StandardInput.Write("echo \\\"h\\\";");
            string result = null;
            while (process.StandardOutput.Peek() > -1)
            {
                result+=(process.StandardOutput.ReadLine());
            }
            process.WaitForExit(100);
            return result;
        }
        private Process GetProcess(string command) {
            command = PreProcess(command);
            Process process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = @"D:\暨南大学\大三\敏捷开发\php\php.exe",
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,
                    Arguments = "-r "+command,

                }
            };
            return process;
        }

        private string PreProcess(string command)
        {
            string result="\"";
            for (int i = 0; i < command.Length; ++i) {
                if (command[i] == '\"') {
                    result+="\\";
                }
                result += command[i];
            }
            result += "\"";
            return result;
        }
    }
}