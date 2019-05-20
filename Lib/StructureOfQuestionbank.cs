using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Lib
{
    [Serializable]
    public class StructureOfQuestionbank
    {
        public static int problemID;
        public static String problemTitle;
        public static int accepted;
        public static int submissions;
        public static float ratio;
        public static StructureOfProblem structureOfProblem;

        public int ProblemID { get => problemID; set => problemID = value; }
        public string ProblemTitle { get => problemTitle; set => problemTitle = value; }
        public int Accepted { get => accepted; set => accepted = value; }
        public int Submissions { get => submissions; set => submissions = value; }
        public float Ratio { get => ratio; set => ratio = value; }
    }
}