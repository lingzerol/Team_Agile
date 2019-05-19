using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    [Serializable]
    public class StructureOfProblem
    {
        // 问题数据结构
        private String questionName = "";
        private String timeLimitIndex = "";
        private String memoryLimitIndex = "";
        private int totalSubmits = 0;
        private int totalAccepts = 0;
        private string acceptsRate = "";
        private String questionDescription = "";
        private String inputDescription = "";
        private String outputDescription = "";
        private String inputSample = "";
        private String outputSample = "";
        private String hint = "";
        private String problemID = "";

        public string ProblemID { get => problemID; set => problemID = value; }
        public string QuestionName { get => questionName; set => questionName = value; }
        public string TimeLimitIndex { get => timeLimitIndex; set => timeLimitIndex = value; }
        public string MemoryLimitIndex { get => memoryLimitIndex; set => memoryLimitIndex = value; }
        public int TotalSubmits { get => totalSubmits; set => totalSubmits = value; }
        public int TotalAccepts { get => totalAccepts; set => totalAccepts = value; }
        public string AcceptsRate { get => acceptsRate; set => acceptsRate = value; }
        public string QuestionDescription { get => questionDescription; set => questionDescription = value; }
        public string InputDescription { get => inputDescription; set => inputDescription = value; }
        public string OutputDescription { get => outputDescription; set => outputDescription = value; }
        public string InputSample { get => inputSample; set => inputSample = value; }
        public string OutputSample { get => outputSample; set => outputSample = value; }
        public string Hint { get => hint; set => hint = value; }
    }
}
