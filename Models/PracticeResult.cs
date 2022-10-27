using System;
using System.Collections.Generic;

namespace Gloomath.Models
{
    public class PracticeResult
    {
        public PracticeConfig PracticeConfig { get; set; }
        public List<QuestionOption> QuestionOptions { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int CorrectQuestions { get; set; }
        public int WrongQuestions { get; set; }
        public int CorrectQuestionsPercentage { get; set; }
        public int WrongQuestionsPercentage { get; set; }
    }
}
