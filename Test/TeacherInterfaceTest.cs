using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Remote;
using System;
using System.Threading;
using System.IO;
namespace Test
{
    /// <summary>
    /// TeacherInterfaceTest 的摘要说明
    /// </summary>
    [TestClass]
    public class TeacherInterfaceTest
    {

        [TestMethod]
        public void saveProblemTest()
        {
            DesiredCapabilities appCapabilities = new DesiredCapabilities();
            string str=Environment.CurrentDirectory;
            appCapabilities.SetCapability("app", Environment.CurrentDirectory+"\\..\\..\\..\\Team_Agile\\bin\\Debug\\Team_Agile.exe");

            WindowsDriver<WindowsElement>  AlarmClockSession = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723"), appCapabilities);
            Assert.IsNotNull(AlarmClockSession);
            WindowsElement teacher_btn=AlarmClockSession.FindElementByName("教师");
            Assert.IsNotNull(teacher_btn);
            teacher_btn.Click();
            Thread.Sleep(2000);
 
            WindowsElement save_btn = AlarmClockSession.FindElementByName("导出");
            Assert.IsNotNull(save_btn);
            save_btn.Click();
            Thread.Sleep(2000);
            WindowsDriver<WindowsElement> save = (WindowsDriver<WindowsElement>)AlarmClockSession.SwitchTo().Window(AlarmClockSession.CurrentWindowHandle);
            WindowsElement ok_btn = save.FindElementByName("确定");
            Assert.IsNotNull(ok_btn);
            ok_btn.Click();
            AlarmClockSession.CloseApp();
            Assert.IsTrue(File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "/Problem.xml"));      
        }
        
    }
}
