using Gloomath.Models;
using System.Collections.Generic;

namespace Gloomath.Constants.Questions
{
    public static class IsPrimeQuestions
    {
        public static List<Question> Questions = new List<Question>()
        {
            // Easy questions
            new Question()
            {
                Title = "É primo",
                Description = "2 é primo?",
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "Sim", IsCorrect = true },
                    new QuestionOption() { Explanation = "Não" }
                }
            },
            new Question()
            {
                Title = "É primo",
                Description = "3 é primo?",
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "Sim", IsCorrect = true },
                    new QuestionOption() { Explanation = "Não" }
                }
            },
            new Question()
            {
                Title = "É primo",
                Description = "4 é primo?",
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "Sim" },
                    new QuestionOption() { Explanation = "Não", IsCorrect = true }
                }
            },
            new Question()
            {
                Title = "É primo",
                Description = "7 é primo?",
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "Sim", IsCorrect = true },
                    new QuestionOption() { Explanation = "Não" }
                }
            },
            new Question()
            {
                Title = "É primo",
                Description = "11 é primo?",
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "Sim", IsCorrect = true },
                    new QuestionOption() { Explanation = "Não" }
                }
            },
            new Question()
            {
                Title = "É primo",
                Description = "15 é primo?",
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "Sim" },
                    new QuestionOption() { Explanation = "Não", IsCorrect = true }
                }
            },
            new Question()
            {
                Title = "É primo",
                Description = "24 é primo?",
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "Sim" },
                    new QuestionOption() { Explanation = "Não", IsCorrect = true }
                }
            },
            new Question()
            {
                Title = "É primo",
                Description = "32 é primo?",
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "Sim" },
                    new QuestionOption() { Explanation = "Não", IsCorrect = true }
                }
            },
            new Question()
            {
                Title = "É primo",
                Description = "43 é primo?",
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "Sim", IsCorrect = true },
                    new QuestionOption() { Explanation = "Não" }
                }
            },
            new Question()
            {
                Title = "É primo",
                Description = "53 é primo?",
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "Sim", IsCorrect = true },
                    new QuestionOption() { Explanation = "Não" }
                }
            },



            // Medium questions
            new Question()
            {
                Title = "É primo",
                Description = "61 é primo?",
                Difficulty = DifficultiesKind.Medium,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "Sim", IsCorrect = true },
                    new QuestionOption() { Explanation = "Não" }
                }
            },
            new Question()
            {
                Title = "É primo",
                Description = "53 é primo?",
                Difficulty = DifficultiesKind.Medium,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "Sim", IsCorrect = true },
                    new QuestionOption() { Explanation = "Não" }
                }
            },
            new Question()
            {
                Title = "É primo",
                Description = "72 é primo?",
                Difficulty = DifficultiesKind.Medium,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "Sim" },
                    new QuestionOption() { Explanation = "Não", IsCorrect = true }
                }
            },
            new Question()
            {
                Title = "É primo",
                Description = "90 é primo?",
                Difficulty = DifficultiesKind.Medium,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "Sim" },
                    new QuestionOption() { Explanation = "Não", IsCorrect = true }
                }
            },
            new Question()
            {
                Title = "É primo",
                Description = "95 é primo?",
                Difficulty = DifficultiesKind.Medium,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "Sim" },
                    new QuestionOption() { Explanation = "Não", IsCorrect = true }
                }
            },
            new Question()
            {
                Title = "É primo",
                Description = "101 é primo?",
                Difficulty = DifficultiesKind.Medium,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "Sim", IsCorrect = true },
                    new QuestionOption() { Explanation = "Não" }
                }
            },
            new Question()
            {
                Title = "É primo",
                Description = "103 é primo?",
                Difficulty = DifficultiesKind.Medium,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "Sim", IsCorrect = true },
                    new QuestionOption() { Explanation = "Não" }
                }
            },
            new Question()
            {
                Title = "É primo",
                Description = "104 é primo?",
                Difficulty = DifficultiesKind.Medium,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "Sim" },
                    new QuestionOption() { Explanation = "Não", IsCorrect = true }
                }
            },
            new Question()
            {
                Title = "É primo",
                Description = "106 é primo?",
                Difficulty = DifficultiesKind.Medium,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "Sim" },
                    new QuestionOption() { Explanation = "Não", IsCorrect = true }
                }
            },
            new Question()
            {
                Title = "É primo",
                Description = "113 é primo?",
                Difficulty = DifficultiesKind.Medium,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "Sim", IsCorrect = true },
                    new QuestionOption() { Explanation = "Não" }
                }
            },
            


            // Hard questions
            new Question()
            {
                Title = "É primo",
                Description = "293 é primo?",
                Difficulty = DifficultiesKind.Hard,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "Sim", IsCorrect = true },
                    new QuestionOption() { Explanation = "Não" }
                }
            },
            new Question()
            {
                Title = "É primo",
                Description = "641 é primo?",
                Difficulty = DifficultiesKind.Hard,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "Sim", IsCorrect = true },
                    new QuestionOption() { Explanation = "Não" }
                }
            },
            new Question()
            {
                Title = "É primo",
                Description = "653 é primo?",
                Difficulty = DifficultiesKind.Hard,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "Sim", IsCorrect = true },
                    new QuestionOption() { Explanation = "Não" }
                }
            },
            new Question()
            {
                Title = "É primo",
                Description = "720 é primo?",
                Difficulty = DifficultiesKind.Hard,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "Sim" },
                    new QuestionOption() { Explanation = "Não", IsCorrect = true }
                }
            },
            new Question()
            {
                Title = "É primo",
                Description = "740 é primo?",
                Difficulty = DifficultiesKind.Hard,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "Sim" },
                    new QuestionOption() { Explanation = "Não", IsCorrect = true }
                }
            },
            new Question()
            {
                Title = "É primo",
                Description = "758 é primo?",
                Difficulty = DifficultiesKind.Hard,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "Sim" },
                    new QuestionOption() { Explanation = "Não", IsCorrect = true }
                }
            },
            new Question()
            {
                Title = "É primo",
                Description = "830 é primo?",
                Difficulty = DifficultiesKind.Hard,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "Sim" },
                    new QuestionOption() { Explanation = "Não", IsCorrect = true }
                }
            },
            new Question()
            {
                Title = "É primo",
                Description = "836 é primo?",
                Difficulty = DifficultiesKind.Hard,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "Sim" },
                    new QuestionOption() { Explanation = "Não", IsCorrect = true }
                }
            },
            new Question()
            {
                Title = "É primo",
                Description = "906 é primo?",
                Difficulty = DifficultiesKind.Hard,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "Sim" },
                    new QuestionOption() { Explanation = "Não", IsCorrect = true  }
                }
            },
            new Question()
            {
                Title = "É primo",
                Description = "997 é primo?",
                Difficulty = DifficultiesKind.Hard,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "Sim", IsCorrect = true },
                    new QuestionOption() { Explanation = "Não" }
                }
            },
        };
    }
}
