using System.Collections.Generic;

namespace Gloomath.Models
{
    public class Question
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DifficultiesKind Difficulty { get; set; } = DifficultiesKind.Easy;
        public List<QuestionOption> Options { get; set; }
    }
}