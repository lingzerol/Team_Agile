using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Lib
{
    public class QuestionBankDS
    {
        public int pro_ID;
        public string problemTitle;
        public int accepted;
        public int submissions;
        public float ratio;
    }
}