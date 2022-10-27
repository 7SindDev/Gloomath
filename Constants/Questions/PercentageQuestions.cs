using Gloomath.Models;
using System.Collections.Generic;

namespace Gloomath.Constants.Questions
{
    public static class PercentageQuestions
    {
        public static List<Question> Questions = new List<Question>()
        {
            // Easy questions
            new Question()
            {
                Title = "Porcentagem",
                Description = "Quanto é 20% de 100?",
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "80" },
                    new QuestionOption() { Explanation = "60" },
                    new QuestionOption() { Explanation = "40" },
                    new QuestionOption() { Explanation = "20", IsCorrect = true },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Porcentagem",
                Description = "Quanto é 50% de 100?",
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "80" },
                    new QuestionOption() { Explanation = "50", IsCorrect = true },
                    new QuestionOption() { Explanation = "30" },
                    new QuestionOption() { Explanation = "20" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Porcentagem",
                Description = "Quanto é 25% de 50?",
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "15" },
                    new QuestionOption() { Explanation = "12,5", IsCorrect = true },
                    new QuestionOption() { Explanation = "10" },
                    new QuestionOption() { Explanation = "7,5" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Porcentagem",
                Description = "Quanto é 50% de 250?",
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "175" },
                    new QuestionOption() { Explanation = "150" },
                    new QuestionOption() { Explanation = "125", IsCorrect = true },
                    new QuestionOption() { Explanation = "100" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Porcentagem",
                Description = "Quanto é 60% de 300?",
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "230" },
                    new QuestionOption() { Explanation = "210" },
                    new QuestionOption() { Explanation = "180", IsCorrect = true },
                    new QuestionOption() { Explanation = "150" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Porcentagem",
                Description = "Quanto é 40% de 160?",
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "64", IsCorrect = true },
                    new QuestionOption() { Explanation = "32" },
                    new QuestionOption() { Explanation = "18" },
                    new QuestionOption() { Explanation = "6" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Porcentagem",
                Description = "Quanto é 40% de 350?",
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "166" },
                    new QuestionOption() { Explanation = "135" },
                    new QuestionOption() { Explanation = "99" },
                    new QuestionOption() { Explanation = "56" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas", IsCorrect = true },
                }
            },
            new Question()
            {
                Title = "Porcentagem",
                Description = "Quanto é 60% de 320?",
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "235" },
                    new QuestionOption() { Explanation = "192", IsCorrect = true },
                    new QuestionOption() { Explanation = "155" },
                    new QuestionOption() { Explanation = "132" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Porcentagem",
                Description = "Quanto é 20% de 150?",
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "50" },
                    new QuestionOption() { Explanation = "40" },
                    new QuestionOption() { Explanation = "30", IsCorrect = true },
                    new QuestionOption() { Explanation = "20" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Porcentagem",
                Description = "Quanto é 75% de 120?",
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "90", IsCorrect = true },
                    new QuestionOption() { Explanation = "80" },
                    new QuestionOption() { Explanation = "70" },
                    new QuestionOption() { Explanation = "60" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },



            // Medium questions
            new Question()
            {
                Title = "Porcentagem",
                Description = "Quanto é 50% de 500",
                Difficulty = DifficultiesKind.Medium,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "300" },
                    new QuestionOption() { Explanation = "250", IsCorrect = true },
                    new QuestionOption() { Explanation = "200" },
                    new QuestionOption() { Explanation = "150" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Porcentagem",
                Description = "Quanto é 60% de 500",
                Difficulty = DifficultiesKind.Medium,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "300", IsCorrect = true },
                    new QuestionOption() { Explanation = "250" },
                    new QuestionOption() { Explanation = "200" },
                    new QuestionOption() { Explanation = "150" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Porcentagem",
                Description = "Quanto é 50% de 700",
                Difficulty = DifficultiesKind.Medium,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "350", IsCorrect = true },
                    new QuestionOption() { Explanation = "300" },
                    new QuestionOption() { Explanation = "250" },
                    new QuestionOption() { Explanation = "200" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Porcentagem",
                Description = "Quanto é 95% de 40",
                Difficulty = DifficultiesKind.Medium,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "40" },
                    new QuestionOption() { Explanation = "38", IsCorrect = true },
                    new QuestionOption() { Explanation = "36" },
                    new QuestionOption() { Explanation = "34" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Porcentagem",
                Description = "Quanto é 40% de 120",
                Difficulty = DifficultiesKind.Medium,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "68" },
                    new QuestionOption() { Explanation = "48", IsCorrect = true },
                    new QuestionOption() { Explanation = "36" },
                    new QuestionOption() { Explanation = "34" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Porcentagem",
                Description = "Quanto é 70% de 900",
                Difficulty = DifficultiesKind.Medium,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "630", IsCorrect = true },
                    new QuestionOption() { Explanation = "650" },
                    new QuestionOption() { Explanation = "670" },
                    new QuestionOption() { Explanation = "690" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Porcentagem",
                Description = "Quanto é 50% de 2500",
                Difficulty = DifficultiesKind.Medium,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "1.500" },
                    new QuestionOption() { Explanation = "1.240" },
                    new QuestionOption() { Explanation = "1.000" },
                    new QuestionOption() { Explanation = "750" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas", IsCorrect = true },
                }
            },
            new Question()
            {
                Title = "Porcentagem",
                Description = "Quanto é 75% de 340",
                Difficulty = DifficultiesKind.Medium,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "255", IsCorrect = true },
                    new QuestionOption() { Explanation = "233" },
                    new QuestionOption() { Explanation = "201" },
                    new QuestionOption() { Explanation = "150" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Porcentagem",
                Description = "Quanto é 80% de 520",
                Difficulty = DifficultiesKind.Medium,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "470" },
                    new QuestionOption() { Explanation = "460" },
                    new QuestionOption() { Explanation = "450" },
                    new QuestionOption() { Explanation = "416", IsCorrect = true },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Porcentagem",
                Description = "Quanto é 30% de 520",
                Difficulty = DifficultiesKind.Medium,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "304" },
                    new QuestionOption() { Explanation = "205" },
                    new QuestionOption() { Explanation = "194" },
                    new QuestionOption() { Explanation = "150" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas", IsCorrect = true },
                }
            },
            


            // Hard questions
            new Question()
            {
                Title = "Porcentagem",
                Description = "Quanto é 120% de 520",
                Difficulty = DifficultiesKind.Hard,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "630" },
                    new QuestionOption() { Explanation = "624", IsCorrect = true },
                    new QuestionOption() { Explanation = "618" },
                    new QuestionOption() { Explanation = "612" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Porcentagem",
                Description = "Quanto é 150% de 500",
                Difficulty = DifficultiesKind.Hard,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "600" },
                    new QuestionOption() { Explanation = "650" },
                    new QuestionOption() { Explanation = "700" },
                    new QuestionOption() { Explanation = "750", IsCorrect = true },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Porcentagem",
                Description = "Quanto é 150% de 500",
                Difficulty = DifficultiesKind.Hard,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "600" },
                    new QuestionOption() { Explanation = "650" },
                    new QuestionOption() { Explanation = "700" },
                    new QuestionOption() { Explanation = "750", IsCorrect = true },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Porcentagem",
                Description = "Quanto é 200% de 2500",
                Difficulty = DifficultiesKind.Hard,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "6.000" },
                    new QuestionOption() { Explanation = "5.500" },
                    new QuestionOption() { Explanation = "5.000", IsCorrect = true },
                    new QuestionOption() { Explanation = "4.500" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Porcentagem",
                Description = "Quanto é 130% de 1700",
                Difficulty = DifficultiesKind.Hard,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "2.210", IsCorrect = true },
                    new QuestionOption() { Explanation = "2.170" },
                    new QuestionOption() { Explanation = "2.150" },
                    new QuestionOption() { Explanation = "2.130" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Porcentagem",
                Description = "Quanto é 20% de 8450",
                Difficulty = DifficultiesKind.Hard,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "2.650" },
                    new QuestionOption() { Explanation = "2.345" },
                    new QuestionOption() { Explanation = "2.005" },
                    new QuestionOption() { Explanation = "1.695" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas", IsCorrect = true },
                }
            },
            new Question()
            {
                Title = "Porcentagem",
                Description = "Quanto é 40% de 50% de 50",
                Difficulty = DifficultiesKind.Hard,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "40" },
                    new QuestionOption() { Explanation = "30" },
                    new QuestionOption() { Explanation = "20" },
                    new QuestionOption() { Explanation = "10", IsCorrect = true },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Porcentagem",
                Description = "Quanto é 150% de 50% de 100",
                Difficulty = DifficultiesKind.Hard,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "100" },
                    new QuestionOption() { Explanation = "75", IsCorrect = true },
                    new QuestionOption() { Explanation = "50" },
                    new QuestionOption() { Explanation = "25" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Porcentagem",
                Description = "Quanto é 50% de 50% de 200",
                Difficulty = DifficultiesKind.Hard,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "100" },
                    new QuestionOption() { Explanation = "75" },
                    new QuestionOption() { Explanation = "50", IsCorrect = true },
                    new QuestionOption() { Explanation = "25" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Porcentagem",
                Description = "Quanto é 250% de 60% de 950",
                Difficulty = DifficultiesKind.Hard,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "1.500" },
                    new QuestionOption() { Explanation = "1.425", IsCorrect = true },
                    new QuestionOption() { Explanation = "1.325" },
                    new QuestionOption() { Explanation = "1.225" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
        };
    }
}
