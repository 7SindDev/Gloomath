using Gloomath.Models;
using System.Collections.Generic;

namespace Gloomath.Constants.Questions
{
    public static class MMCAndMDCQuestions
    {
        public static List<Question> Questions = new List<Question>()
        {
            // Easy questions
            new Question()
            {
                Title = "MMC",
                Description = "Qual é o MMC de 10 e 15?",
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "60" },
                    new QuestionOption() { Explanation = "40" },
                    new QuestionOption() { Explanation = "30", IsCorrect = true  },
                    new QuestionOption() { Explanation = "20" },
                    new QuestionOption() { Explanation = "10" },
                }
            },
            new Question()
            {
                Title = "MMC",
                Description = "Qual é o MMC de 20 e 15?",
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "60", IsCorrect = true },
                    new QuestionOption() { Explanation = "40" },
                    new QuestionOption() { Explanation = "30" },
                    new QuestionOption() { Explanation = "20" },
                    new QuestionOption() { Explanation = "10" },
                }
            },
            new Question()
            {
                Title = "MMC",
                Description = "Qual é o MMC de 30 e 54?",
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "300" },
                    new QuestionOption() { Explanation = "290" },
                    new QuestionOption() { Explanation = "280" },
                    new QuestionOption() { Explanation = "270", IsCorrect = true },
                    new QuestionOption() { Explanation = "260" },
                }
            },
            new Question()
            {
                Title = "MMC",
                Description = "Qual é o MMC de 50 e 75?",
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "190" },
                    new QuestionOption() { Explanation = "180" },
                    new QuestionOption() { Explanation = "170" },
                    new QuestionOption() { Explanation = "160" },
                    new QuestionOption() { Explanation = "150", IsCorrect = true },
                }
            },
            new Question()
            {
                Title = "MMC",
                Description = "Qual é o MMC de 60 e 75?",
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "340" },
                    new QuestionOption() { Explanation = "330" },
                    new QuestionOption() { Explanation = "320" },
                    new QuestionOption() { Explanation = "310" },
                    new QuestionOption() { Explanation = "300", IsCorrect = true },
                }
            },
            new Question()
            {
                Title = "MDC",
                Description = "Qual é o MDC de 30 e 60?",
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "40" },
                    new QuestionOption() { Explanation = "30", IsCorrect = true  },
                    new QuestionOption() { Explanation = "20" },
                    new QuestionOption() { Explanation = "10" },
                    new QuestionOption() { Explanation = "5" },
                }
            },
            new Question()
            {
                Title = "MDC",
                Description = "Qual é o MDC de 30 e 70?",
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "90" },
                    new QuestionOption() { Explanation = "50" },
                    new QuestionOption() { Explanation = "30" },
                    new QuestionOption() { Explanation = "20" },
                    new QuestionOption() { Explanation = "10", IsCorrect = true },
                }
            },
            new Question()
            {
                Title = "MDC",
                Description = "Qual é o MDC de 50 e 70?",
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "60" },
                    new QuestionOption() { Explanation = "40" },
                    new QuestionOption() { Explanation = "25" },
                    new QuestionOption() { Explanation = "15" },
                    new QuestionOption() { Explanation = "10", IsCorrect = true },
                }
            },
            new Question()
            {
                Title = "MDC",
                Description = "Qual é o MDC de 90 e 55?",
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "10" },
                    new QuestionOption() { Explanation = "7" },
                    new QuestionOption() { Explanation = "5", IsCorrect = true },
                    new QuestionOption() { Explanation = "2" },
                    new QuestionOption() { Explanation = "1" },
                }
            },
            new Question()
            {
                Title = "MDC",
                Description = "Qual é o MDC de 25 e 50?",
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "25", IsCorrect = true },
                    new QuestionOption() { Explanation = "50" },
                    new QuestionOption() { Explanation = "75" },
                    new QuestionOption() { Explanation = "100" },
                    new QuestionOption() { Explanation = "125" },
                }
            },



            // Medium questions
            new Question()
            {
                Title = "MMC",
                Description = "Qual é o MMC de 20, 25 e 30?",
                Difficulty = DifficultiesKind.Medium,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "300", IsCorrect = true },
                    new QuestionOption() { Explanation = "320" },
                    new QuestionOption() { Explanation = "340" },
                    new QuestionOption() { Explanation = "360" },
                    new QuestionOption() { Explanation = "380" },
                }
            },
            new Question()
            {
                Title = "MMC",
                Description = "Qual é o MMC de 30, 25 e 10?",
                Difficulty = DifficultiesKind.Medium,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "210" },
                    new QuestionOption() { Explanation = "190" },
                    new QuestionOption() { Explanation = "170" },
                    new QuestionOption() { Explanation = "150", IsCorrect = true },
                    new QuestionOption() { Explanation = "130" },
                }
            },
            new Question()
            {
                Title = "MMC",
                Description = "Qual é o MMC de 50, 25 e 10?",
                Difficulty = DifficultiesKind.Medium,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "110" },
                    new QuestionOption() { Explanation = "90" },
                    new QuestionOption() { Explanation = "70" },
                    new QuestionOption() { Explanation = "50", IsCorrect = true },
                    new QuestionOption() { Explanation = "30" },
                }
            },
            new Question()
            {
                Title = "MMC",
                Description = "Qual é o MMC de 150, 100 e 50?",
                Difficulty = DifficultiesKind.Medium,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "380" },
                    new QuestionOption() { Explanation = "360" },
                    new QuestionOption() { Explanation = "340" },
                    new QuestionOption() { Explanation = "320" },
                    new QuestionOption() { Explanation = "300", IsCorrect = true },
                }
            },
            new Question()
            {
                Title = "MMC",
                Description = "Qual é o MMC de 150, 100 e 100?",
                Difficulty = DifficultiesKind.Medium,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "300", IsCorrect = true },
                    new QuestionOption() { Explanation = "320" },
                    new QuestionOption() { Explanation = "340" },
                    new QuestionOption() { Explanation = "360" },
                    new QuestionOption() { Explanation = "380" },
                }
            },
            new Question()
            {
                Title = "MDC",
                Description = "Qual é o MDC de 190, 90 e 20?",
                Difficulty = DifficultiesKind.Medium,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "10", IsCorrect = true },
                    new QuestionOption() { Explanation = "20" },
                    new QuestionOption() { Explanation = "30" },
                    new QuestionOption() { Explanation = "40" },
                    new QuestionOption() { Explanation = "50" },
                }
            },
            new Question()
            {
                Title = "MDC",
                Description = "Qual é o MDC de 210, 235 e 50",
                Difficulty = DifficultiesKind.Medium,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "1" },
                    new QuestionOption() { Explanation = "2" },
                    new QuestionOption() { Explanation = "3" },
                    new QuestionOption() { Explanation = "4" },
                    new QuestionOption() { Explanation = "5", IsCorrect = true },
                }
            },
            new Question()
            {
                Title = "MDC",
                Description = "Qual é o MDC de 350, 320 e 290",
                Difficulty = DifficultiesKind.Medium,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "30" },
                    new QuestionOption() { Explanation = "20" },
                    new QuestionOption() { Explanation = "10", IsCorrect = true },
                    new QuestionOption() { Explanation = "5" },
                    new QuestionOption() { Explanation = "2" },
                }
            },
            new Question()
            {
                Title = "MDC",
                Description = "Qual é o MDC de 175, 40 e 20?",
                Difficulty = DifficultiesKind.Medium,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "15" },
                    new QuestionOption() { Explanation = "10" },
                    new QuestionOption() { Explanation = "5", IsCorrect = true },
                    new QuestionOption() { Explanation = "2" },
                    new QuestionOption() { Explanation = "1" },
                }
            },
            new Question()
            {
                Title = "MDC",
                Description = "Qual é o MDC de 305, 40 e 20?",
                Difficulty = DifficultiesKind.Medium,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "15" },
                    new QuestionOption() { Explanation = "10" },
                    new QuestionOption() { Explanation = "5", IsCorrect = true },
                    new QuestionOption() { Explanation = "2" },
                    new QuestionOption() { Explanation = "1" },
                }
            },



            // Hard questions
            new Question()
            {
                Title = "MMC",
                Description = "Qual é o MMC de 280, 150 e 40?",
                Difficulty = DifficultiesKind.Hard,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "4400" },
                    new QuestionOption() { Explanation = "4200", IsCorrect = true },
                    new QuestionOption() { Explanation = "4000" },
                    new QuestionOption() { Explanation = "3800" },
                    new QuestionOption() { Explanation = "3600" },
                }
            },
            new Question()
            {
                Title = "MMC",
                Description = "Qual é o MMC de 370, 80 e 40?",
                Difficulty = DifficultiesKind.Hard,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "4400" },
                    new QuestionOption() { Explanation = "4200", IsCorrect = true },
                    new QuestionOption() { Explanation = "4000" },
                    new QuestionOption() { Explanation = "3800" },
                    new QuestionOption() { Explanation = "3600" },
                }
            },
            new Question()
            {
                Title = "MMC",
                Description = "Qual é o MMC de 150, 80 e 40?",
                Difficulty = DifficultiesKind.Hard,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "2300" },
                    new QuestionOption() { Explanation = "1500" },
                    new QuestionOption() { Explanation = "1200", IsCorrect = true },
                    new QuestionOption() { Explanation = "900" },
                    new QuestionOption() { Explanation = "530" },
                }
            },
            new Question()
            {
                Title = "MMC",
                Description = "Qual é o MMC de 180, 305 e 1050?",
                Difficulty = DifficultiesKind.Hard,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "384.300", IsCorrect = true },
                    new QuestionOption() { Explanation = "334.700" },
                    new QuestionOption() { Explanation = "312.900" },
                    new QuestionOption() { Explanation = "234.630" },
                    new QuestionOption() { Explanation = "191.300" },
                }
            },
            new Question()
            {
                Title = "MMC",
                Description = "Qual é o MMC de 200, 305 e 1050?",
                Difficulty = DifficultiesKind.Hard,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "256.200", IsCorrect = true },
                    new QuestionOption() { Explanation = "234.700" },
                    new QuestionOption() { Explanation = "212.900" },
                    new QuestionOption() { Explanation = "191.630" },
                    new QuestionOption() { Explanation = "143.500" },
                }
            },
            new Question()
            {
                Title = "MDC",
                Description = "Qual é o MDC de 700, 250, 350?",
                Difficulty = DifficultiesKind.Hard,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "90" },
                    new QuestionOption() { Explanation = "80" },
                    new QuestionOption() { Explanation = "70" },
                    new QuestionOption() { Explanation = "60" },
                    new QuestionOption() { Explanation = "50", IsCorrect = true },
                }
            },
            new Question()
            {
                Title = "MDC",
                Description = "Qual é o MDC de 700, 280, 350?",
                Difficulty = DifficultiesKind.Hard,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "90" },
                    new QuestionOption() { Explanation = "80" },
                    new QuestionOption() { Explanation = "70", IsCorrect = true },
                    new QuestionOption() { Explanation = "60" },
                    new QuestionOption() { Explanation = "50" },
                }
            },
            new Question()
            {
                Title = "MDC",
                Description = "Qual é o MDC de 250, 280, 350?",
                Difficulty = DifficultiesKind.Hard,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "25" },
                    new QuestionOption() { Explanation = "20" },
                    new QuestionOption() { Explanation = "15" },
                    new QuestionOption() { Explanation = "10", IsCorrect = true  },
                    new QuestionOption() { Explanation = "5" },
                }
            },
            new Question()
            {
                Title = "MDC",
                Description = "Qual é o MDC de 450, 240, 540?",
                Difficulty = DifficultiesKind.Hard,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "30", IsCorrect = true },
                    new QuestionOption() { Explanation = "25" },
                    new QuestionOption() { Explanation = "20" },
                    new QuestionOption() { Explanation = "15"  },
                    new QuestionOption() { Explanation = "10" },
                }
            },
            new Question()
            {
                Title = "MDC",
                Description = "Qual é o MDC de 500, 750, 235?",
                Difficulty = DifficultiesKind.Hard,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "25" },
                    new QuestionOption() { Explanation = "20" },
                    new QuestionOption() { Explanation = "15" },
                    new QuestionOption() { Explanation = "10"  },
                    new QuestionOption() { Explanation = "5", IsCorrect = true },
                }
            }
        };
    }
}
