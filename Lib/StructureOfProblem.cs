﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    public class StructureOfProblem
    {
        // 问题数据结构
        private string questionName;
        private string timeLimitIndex;
        private string memoryLimitIndex;
        private string totalSubmits;
        private string totalAccepts;
        private string acceptsRate;
        private string questionDescription;
        private string inputDescription;
        private string outputDescription;
        private string inputSample;
        private string outputSample;
        private string hint;
        private string problemID;

        public string ProblemID { get => problemID; set => problemID = value; }
        public string QuestionName { get => questionName; set => questionName = value; }
        public string TimeLimitIndex { get => timeLimitIndex; set => timeLimitIndex = value; }
        public string MemoryLimitIndex { get => memoryLimitIndex; set => memoryLimitIndex = value; }
        public string TotalSubmits { get => totalSubmits; set => totalSubmits = value; }
        public string TotalAccepts { get => totalAccepts; set => totalAccepts = value; }
        public string AcceptsRate { get => acceptsRate; set => acceptsRate = value; }
        public string QuestionDescription { get => questionDescription; set => questionDescription = value; }
        public string InputDescription { get => inputDescription; set => inputDescription = value; }
        public string OutputDescription { get => outputDescription; set => outputDescription = value; }
        public string InputSample { get => inputSample; set => inputSample = value; }
        public string OutputSample { get => outputSample; set => outputSample = value; }
        public string Hint { get => hint; set => hint = value; }
    }
}
