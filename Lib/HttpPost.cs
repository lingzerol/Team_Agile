using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    public class HttpPost
    {
        private string _who;

        public HttpPost(string who) {
            this._who = who;
        }

        public string Excute(string command)
        {
            return this._who;
            //待补充
        }
    }
}
