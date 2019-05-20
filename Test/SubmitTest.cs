using System;
using System.Reflection;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Team_Agile.Pages;

namespace Test
{

    [TestClass]
    public class SubmitTest
    {
        private void callOnClick(Button btn)
        {
            //建立一个类型  
            Type t = typeof(Button);
            //参数对象  
            object[] p = new object[1];
            //产生方法  
            MethodInfo m = t.GetMethod("OnClick", BindingFlags.NonPublic | BindingFlags.Instance);
            //参数赋值。传入函数  
            p[0] = EventArgs.Empty;
            //调用  
            m.Invoke(btn, p);
            return;
        }
        [TestMethod]
        public void Reset()
        {
            SubmitProblem s = new SubmitProblem();
            callOnClick(s.Reset);
            if(s.SourceCode.Text.ToString()!="")
            {
                Assert.Fail();
            }

        }
    }
}
