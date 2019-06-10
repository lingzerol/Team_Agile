using System;

namespace Lib
{
    public class PHPRunner
    {
        private string COMMAND_PATH = "";
        private string USER_AGENT = "My Frog Exploer";
        private string SERVER_PROTOCOL = "HTTP/1.1";

        public string ErrorMessage { get; set; } = "";
        public string Code { get; set; } = "";
        public string QueryString { get; set; } = "";
        public string DefaultCGISourceFileName { get; set; } = "main.php";
        public string PostData { get; set; } = "";

        public Boolean SetCommandPath(String commandPath)
        {
            COMMAND_PATH = commandPath;
            String phpcgiPath = System.IO.Path.Combine(COMMAND_PATH, "php-cgi.exe");
            Boolean bResult = System.IO.File.Exists(phpcgiPath);
            if (!bResult) ErrorMessage = phpcgiPath + " not exist";
            return bResult;
        }

        public  PHPRunner()
        {
            this.SetCommandPath("../../../php");
        }




        public String run()
        {
            String cgiFileWithPath = System.IO.Path.Combine(Environment.CurrentDirectory, this.DefaultCGISourceFileName);
            System.IO.File.Delete(cgiFileWithPath);
            this.Code = "<?php "+ this.Code;
            System.IO.File.WriteAllText(cgiFileWithPath, this.Code);
            if (!System.IO.File.Exists(cgiFileWithPath))
            {
                //cmd not exists
                return cgiFileWithPath + " not wroten";
            }

            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.StartInfo.FileName = System.IO.Path.Combine(COMMAND_PATH, "php-cgi.exe");
            if (!System.IO.File.Exists(process.StartInfo.FileName))
            {
                //cmd not exists
                return process.StartInfo.FileName + " not exist";
            }

            //作为参数传入
            process.StartInfo.Arguments = "-q -f \"" + cgiFileWithPath + "\" ";

            //filling HTTP Header
            process.StartInfo.EnvironmentVariables.Add("REDIRECT_STATUS", "200");
            process.StartInfo.EnvironmentVariables.Add("SERVER_INTERFACE", "CGI/1.1");
            process.StartInfo.EnvironmentVariables.Add("REMOTE_ADDR", "127.0.0.1");
            process.StartInfo.EnvironmentVariables.Add("SCRIPT_FILENAME", cgiFileWithPath);
            process.StartInfo.EnvironmentVariables.Add("USER_AGENT", USER_AGENT);
            String requestMethod = "GET";
            if (PostData.Length > 0)
            {
                requestMethod = "POST";
                process.StartInfo.EnvironmentVariables.Add("CONTENT_TYPE", "application/x-www-form-urlencoded");
                process.StartInfo.EnvironmentVariables.Add("CONTENT_LENGTH", PostData.Length + "");
            }
            process.StartInfo.EnvironmentVariables.Add("REQUEST_METHOD", requestMethod);
            process.StartInfo.EnvironmentVariables.Add("SERVER_PORT", "8888");
            //process.StartInfo.EnvironmentVariables.Add("REFERER", "");
            process.StartInfo.EnvironmentVariables.Add("SERVER_PROTOCOL", SERVER_PROTOCOL);
            process.StartInfo.EnvironmentVariables.Add("QUERY_STRING", QueryString);

            process.StartInfo.UseShellExecute = false;
            process.StartInfo.StandardOutputEncoding = System.Text.Encoding.UTF8;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.CreateNoWindow = true;

            process.Start();
            if (PostData.Length > 0)
            {
                process.StandardInput.Write(PostData);
                process.StandardInput.Flush();
            }


            String httpResult = "";

            //skip http header
            do
            {
                httpResult = process.StandardOutput.ReadLine();
            }
            while (httpResult.Length > 0);

            httpResult = process.StandardOutput.ReadToEnd();
            process.Close();
            process.Dispose();

            return httpResult;

        }
    }

}