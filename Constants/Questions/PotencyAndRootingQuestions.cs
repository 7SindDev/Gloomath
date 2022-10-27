using Gloomath.Models;
using System.Collections.Generic;

namespace Gloomath.Constants.Questions
{
    public static class PotencyAndRootingQuestions
    {
        public static List<Question> Questions = new List<Question>()
        {
            // Easy questions
            new Question()
            {
                Title = "Potência",
                Description = "Qual é o resultado de 2 ^ 3?",
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "9" },
                    new QuestionOption() { Explanation = "8", IsCorrect = true },
                    new QuestionOption() { Explanation = "7" },
                    new QuestionOption() { Explanation = "6" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Potência",
                Description = "Qual é o resultado de 3 ^ 3?",
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "18" },
                    new QuestionOption() { Explanation = "20" },
                    new QuestionOption() { Explanation = "25" },
                    new QuestionOption() { Explanation = "27", IsCorrect = true },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Potência",
                Description = "Qual é o resultado de 5 ^ 3?",
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "95" },
                    new QuestionOption() { Explanation = "105" },
                    new QuestionOption() { Explanation = "125", IsCorrect = true },
                    new QuestionOption() { Explanation = "150" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Potência",
                Description = "Qual é o resultado de 7 ^ 3?",
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "265" },
                    new QuestionOption() { Explanation = "298" },
                    new QuestionOption() { Explanation = "313" },
                    new QuestionOption() { Explanation = "343", IsCorrect = true },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Potência",
                Description = "Qual é o resultado de 9 ^ 3?",
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "632" },
                    new QuestionOption() { Explanation = "675" },
                    new QuestionOption() { Explanation = "699" },
                    new QuestionOption() { Explanation = "729", IsCorrect = true },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Raiz quadrada",
                Description = "Qual é o resultado de rquadrada(9)?",
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "3", IsCorrect = true },
                    new QuestionOption() { Explanation = "4" },
                    new QuestionOption() { Explanation = "9" },
                    new QuestionOption() { Explanation = "2" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Raiz quadrada",
                Description = "Qual é o resultado de rquadrada(25)?",
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "25" },
                    new QuestionOption() { Explanation = "5", IsCorrect = true  },
                    new QuestionOption() { Explanation = "2" },
                    new QuestionOption() { Explanation = "1" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Raiz quadrada",
                Description = "Qual é o resultado de rquadrada(16)?",
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "16" },
                    new QuestionOption() { Explanation = "8"  },
                    new QuestionOption() { Explanation = "4", IsCorrect = true },
                    new QuestionOption() { Explanation = "2" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Raiz quadrada",
                Description = "Qual é o resultado de rquadrada(36)?",
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "8" },
                    new QuestionOption() { Explanation = "6", IsCorrect = true  },
                    new QuestionOption() { Explanation = "4" },
                    new QuestionOption() { Explanation = "2" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Raiz quadrada",
                Description = "Qual é o resultado de rquadrada(100)?",
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "12" },
                    new QuestionOption() { Explanation = "8"  },
                    new QuestionOption() { Explanation = "4" },
                    new QuestionOption() { Explanation = "2" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas", IsCorrect = true },
                }
            },



            // Medium questions
            new Question()
            {
                Title = "Potência",
                Description = "Qual é o resultado de 3 ^ 4:",
                Difficulty = DifficultiesKind.Medium,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "150" },
                    new QuestionOption() { Explanation = "98" },
                    new QuestionOption() { Explanation = "81", IsCorrect = true },
                    new QuestionOption() { Explanation = "72" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Potência",
                Description = "Qual é o resultado de 8 ^ 4:",
                Difficulty = DifficultiesKind.Medium,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "4.096", IsCorrect = true },
                    new QuestionOption() { Explanation = "4.066" },
                    new QuestionOption() { Explanation = "4.026" },
                    new QuestionOption() { Explanation = "3.996" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Potência",
                Description = "Qual é o resultado de 8 ^ 5:",
                Difficulty = DifficultiesKind.Medium,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "32.768", IsCorrect = true },
                    new QuestionOption() { Explanation = "32.632" },
                    new QuestionOption() { Explanation = "32.584" },
                    new QuestionOption() { Explanation = "32.522" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Potência",
                Description = "Qual é o resultado de 6 ^ 7:",
                Difficulty = DifficultiesKind.Medium,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "279.965" },
                    new QuestionOption() { Explanation = "279.765" },
                    new QuestionOption() { Explanation = "279.465" },
                    new QuestionOption() { Explanation = "279.265", IsCorrect = true  },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Potência",
                Description = "Qual é o resultado de 5 ^ 7?",
                Difficulty = DifficultiesKind.Medium,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "81.345" },
                    new QuestionOption() { Explanation = "79.345" },
                    new QuestionOption() { Explanation = "79.093" },
                    new QuestionOption() { Explanation = "78.125", IsCorrect = true  },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Raiz quadrada",
                Description = "Qual é o resultado de rquadrada(400)?",
                Difficulty = DifficultiesKind.Medium,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "30" },
                    new QuestionOption() { Explanation = "25" },
                    new QuestionOption() { Explanation = "20", IsCorrect = true },
                    new QuestionOption() { Explanation = "15" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Raiz quadrada",
                Description = "Qual é o resultado de rquadrada(196)?",
                Difficulty = DifficultiesKind.Medium,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "20" },
                    new QuestionOption() { Explanation = "18" },
                    new QuestionOption() { Explanation = "16" },
                    new QuestionOption() { Explanation = "14", IsCorrect = true },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Raiz quadrada",
                Description = "Qual é o resultado de rquadrada(225)?",
                Difficulty = DifficultiesKind.Medium,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "20" },
                    new QuestionOption() { Explanation = "17" },
                    new QuestionOption() { Explanation = "15", IsCorrect = true },
                    new QuestionOption() { Explanation = "13" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Raiz quadrada",
                Description = "Qual é o resultado de rquadrada(121)?",
                Difficulty = DifficultiesKind.Medium,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "28" },
                    new QuestionOption() { Explanation = "20" },
                    new QuestionOption() { Explanation = "14" },
                    new QuestionOption() { Explanation = "11", IsCorrect = true },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Raiz quadrada",
                Description = "Qual é o resultado de rquadrada(324)?",
                Difficulty = DifficultiesKind.Medium,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "20" },
                    new QuestionOption() { Explanation = "18", IsCorrect = true },
                    new QuestionOption() { Explanation = "16" },
                    new QuestionOption() { Explanation = "14" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            


            // Hard questions
            new Question()
            {
                Title = "Potência",
                Description = "Qual é o resultado de 10 ^ 5?",
                Difficulty = DifficultiesKind.Hard,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "10.000" },
                    new QuestionOption() { Explanation = "100.000", IsCorrect = true },
                    new QuestionOption() { Explanation = "1.000.000" },
                    new QuestionOption() { Explanation = "10.000.000" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Potência",
                Description = "Qual é o resultado de 13 ^ 5?",
                Difficulty = DifficultiesKind.Hard,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "371.293", IsCorrect = true },
                    new QuestionOption() { Explanation = "270.302" },
                    new QuestionOption() { Explanation = "268.342" },
                    new QuestionOption() { Explanation = "265.942" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Potência",
                Description = "Qual é o resultado de 8 ^ 9?",
                Difficulty = DifficultiesKind.Hard,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "134.217.728", IsCorrect = true },
                    new QuestionOption() { Explanation = "133.865.293" },
                    new QuestionOption() { Explanation = "132.984.234" },
                    new QuestionOption() { Explanation = "131.934.983" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Potência",
                Description = "Qual é o resultado de 16 ^ 4?",
                Difficulty = DifficultiesKind.Hard,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "69.345" },
                    new QuestionOption() { Explanation = "67.445" },
                    new QuestionOption() { Explanation = "65.536", IsCorrect = true },
                    new QuestionOption() { Explanation = "63.895" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Potência",
                Description = "Qual é o resultado de 23 ^ 3?",
                Difficulty = DifficultiesKind.Hard,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "16.132" },
                    new QuestionOption() { Explanation = "14.394" },
                    new QuestionOption() { Explanation = "12.167", IsCorrect = true },
                    new QuestionOption() { Explanation = "10.934" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Raiz cúbica",
                Description = "Qual é o resultado de rcubica(8)?",
                Difficulty = DifficultiesKind.Hard,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "8" },
                    new QuestionOption() { Explanation = "6" },
                    new QuestionOption() { Explanation = "4" },
                    new QuestionOption() { Explanation = "2", IsCorrect = true },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Raiz cúbica",
                Description = "Qual é o resultado de rcubica(125)?",
                Difficulty = DifficultiesKind.Hard,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "10" },
                    new QuestionOption() { Explanation = "8" },
                    new QuestionOption() { Explanation = "6" },
                    new QuestionOption() { Explanation = "5", IsCorrect = true },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Raiz cúbica",
                Description = "Qual é o resultado de rcubica(512)?",
                Difficulty = DifficultiesKind.Hard,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "16" },
                    new QuestionOption() { Explanation = "8", IsCorrect = true },
                    new QuestionOption() { Explanation = "4" },
                    new QuestionOption() { Explanation = "2" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Raiz cúbica",
                Description = "Qual é o resultado de rcubica(1000)?",
                Difficulty = DifficultiesKind.Hard,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "20" },
                    new QuestionOption() { Explanation = "15" },
                    new QuestionOption() { Explanation = "12" },
                    new QuestionOption() { Explanation = "10", IsCorrect = true },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Raiz cúbica",
                Description = "Qual é o resultado de rcubica(2744)?",
                Difficulty = DifficultiesKind.Hard,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "20" },
                    new QuestionOption() { Explanation = "16", IsCorrect = true },
                    new QuestionOption() { Explanation = "14" },
                    new QuestionOption() { Explanation = "10" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
        };
    }
}
