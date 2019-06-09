using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Lib
{
    [Serializable]
    public class StructureOfQuestionStatus
    {
        private int problemID;
        private String problemTitle;
        private int accepted;
        private int acceptsRate;
        private String code;

        public int ProblemID { get => problemID; set => problemID = value; }
        public string ProblemTitle { get => problemTitle; set => problemTitle = value; }
        public int Accepted { get => accepted; set => accepted = value; }
        public int AcceptsRate { get => acceptsRate; set => acceptsRate = value; }
        public string Code { get => code; set => code = value; }
    }
}