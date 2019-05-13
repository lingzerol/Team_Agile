using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Lib
{
    public class StructureOfQuestionbank
    {
        private int problemID;
        private string problemTitle;
        private int accepted;
        private int submissions;
        private float ratio;

        public int ProblemID { get => problemID; set => problemID = value; }
        public string ProblemTitle { get => problemTitle; set => problemTitle = value; }
        public int Accepted { get => accepted; set => accepted = value; }
        public int Submissions { get => submissions; set => submissions = value; }
        public float Ratio { get => ratio; set => ratio = value; }
    }
}