using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Remote;
using System;
using System.Threading;

namespace Test
{
    /// <summary>
    /// TeacherInterfaceTest 的摘要说明
    /// </summary>
    [TestClass]
    public class TeacherInterfaceTest
    {
        private string url = "http://127.0.0.1:4723/";
        private System.Diagnostics.Process pProcess;
        [TestInitialize]
        public void Init() {
            pProcess = new System.Diagnostics.Process();
            pProcess.StartInfo.FileName = @"G:\visual studio project\Projects\Team_Agile\Test\WinAppDriver\WinAppDriver.exe";
            pProcess.StartInfo.RedirectStandardInput = true;
            pProcess.StartInfo.UseShellExecute = false;
            pProcess.StartInfo.RedirectStandardOutput = true;
            pProcess.StartInfo.RedirectStandardError = true;
            //pProcess.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            pProcess.StartInfo.CreateNoWindow = true; //not diplay a windows
            pProcess.Start();

        }

        [TestMethod]
        public void TestMethod1()
        {
            DesiredCapabilities appCapabilities = new DesiredCapabilities();
            appCapabilities.SetCapability("app", "\"G:\\visual studio project\\Projects\\Team_Agile\\Team_Agile\\bin\\Debug\\Team_Agile.exe\"");

            WindowsDriver<WindowsElement>  AlarmClockSession = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723"), appCapabilities);
            Assert.IsNotNull(AlarmClockSession);
            WindowsElement teacher_btn=AlarmClockSession.FindElementByName("教师");
            Assert.IsNotNull(teacher_btn);
            teacher_btn.Click();
            pProcess.StandardInput.WriteLine("\n");
            pProcess.WaitForExit();
        }
        
    }
}
