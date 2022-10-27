using Gloomath.Models;
using System.Collections.Generic;

namespace Gloomath.Constants.Questions
{
    public static class FractionOperationsQuestions
    {
        public static List<Question> Questions = new List<Question>()
        {
            // Easy questions
            new Question()
            {
                Title = "Adição com duas frações com denominadores iguais",
                Description = "Qual é o resultado da soma de 2/6 com 4/6",
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "6/6", IsCorrect = true },
                    new QuestionOption() { Explanation = "5/6" },
                    new QuestionOption() { Explanation = "4/6" },
                    new QuestionOption() { Explanation = "3/6" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Subtração com duas frações com denominadores iguais",
                Description = "Qual é o resultado da operação 10/5 - 5/5?",
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "8/5" },
                    new QuestionOption() { Explanation = "6/5" },
                    new QuestionOption() { Explanation = "5/5", IsCorrect = true },
                    new QuestionOption() { Explanation = "4/5" },
                    new QuestionOption() { Explanation = "3/5" },
                }
            },
            new Question()
            {
                Title = "Multiplicação com duas frações com denominadores iguais",
                Description = "Qual é o resultado da operação 15/5 * 5/5?",
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "80/30", IsCorrect = true },
                    new QuestionOption() { Explanation = "75/30" },
                    new QuestionOption() { Explanation = "75/25" },
                    new QuestionOption() { Explanation = "70/25" },
                    new QuestionOption() { Explanation = "80/25" },
                }
            },
            new Question()
            {
                Title = "Divisão com duas frações com denominadores iguais",
                Description = "Qual é o resultado da operação 20/3 : 10/2?",
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "40/25" },
                    new QuestionOption() { Explanation = "30/25" },
                    new QuestionOption() { Explanation = "35/30" },
                    new QuestionOption() { Explanation = "40/30" },
                    new QuestionOption() { Explanation = "35/25", IsCorrect = true },
                }
            },
            new Question()
            {
                Title = "Adição com duas frações com denominadores diferentes",
                Description = "Qual é o resultado da operação 15/3 + 15/5?",
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "110/15" },
                    new QuestionOption() { Explanation = "115/15" },
                    new QuestionOption() { Explanation = "120/20" },
                    new QuestionOption() { Explanation = "120/15", IsCorrect = true },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Subtração com duas frações com denominadores diferentes",
                Description = "Qual é o resultado da operação 15/3 + 15/5?",
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "30/20" },
                    new QuestionOption() { Explanation = "30/25" },
                    new QuestionOption() { Explanation = "30/30" },
                    new QuestionOption() { Explanation = "30/35" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas", IsCorrect = true },
                }
            },
            new Question()
            {
                Title = "Multiplicação com duas frações com denominadores diferentes",
                Description = "Qual é o resultado da operação 10/5 * 15/10?",
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "150/50", IsCorrect = true },
                    new QuestionOption() { Explanation = "145/45" },
                    new QuestionOption() { Explanation = "140/50" },
                    new QuestionOption() { Explanation = "150/55" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Divisão com duas frações com denominadores diferentes",
                Description = "Qual é o resultado da operação 15/5 : 3/7?",
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "115/30" },
                    new QuestionOption() { Explanation = "110/35" },
                    new QuestionOption() { Explanation = "100/35" },
                    new QuestionOption() { Explanation = "105/35", IsCorrect = true },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Adição com três frações com denominadores iguais",
                Description = "Qual é o resultado da operação 30/15 + 15/15 + 25/15",
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "70/15", IsCorrect = true },
                    new QuestionOption() { Explanation = "80/15" },
                    new QuestionOption() { Explanation = "90/15" },
                    new QuestionOption() { Explanation = "50/15" },
                    new QuestionOption() { Explanation = "85/15" },
                }
            },
            new Question()
            {
                Title = "Subtração com três frações com denominadores iguais",
                Description = "Qual é o resultado da operação 50/30 + 30/30 + 20/30",
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "100/30", IsCorrect = true },
                    new QuestionOption() { Explanation = "105/30" },
                    new QuestionOption() { Explanation = "110/30" },
                    new QuestionOption() { Explanation = "115/30" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },



            // Medium questions
            new Question()
            {
                Title = "Adição com três frações com denominadores iguais",
                Description = "Qual é o resultado da operação 45/15 + 15/15 + 25/15?",
                Difficulty = DifficultiesKind.Medium,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "90/15" },
                    new QuestionOption() { Explanation = "80/15", IsCorrect = true },
                    new QuestionOption() { Explanation = "85/15" },
                    new QuestionOption() { Explanation = "95/15" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Subtração com três frações com denominadores iguais",
                Description = "Qual é o resultado da operação 90/15 - 76/15 - 14/15?",
                Difficulty = DifficultiesKind.Medium,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "3/15", IsCorrect = true },
                    new QuestionOption() { Explanation = "4/15" },
                    new QuestionOption() { Explanation = "5/15" },
                    new QuestionOption() { Explanation = "6/15" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Multiplicação com três frações com denominadores iguais",
                Description = "Qual é o resultado da operação 10/10 * 20/10 * 30/10?",
                Difficulty = DifficultiesKind.Medium,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "6.300/1.000" },
                    new QuestionOption() { Explanation = "6.200/1.000" },
                    new QuestionOption() { Explanation = "6.100/1.000" },
                    new QuestionOption() { Explanation = "6.000/1.000", IsCorrect = true },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Divisão com três frações com denominadores iguais",
                Description = "Qual é o resultado da operação 10/10 : 20/10 : 30/10?",
                Difficulty = DifficultiesKind.Medium,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "900/5.800" },
                    new QuestionOption() { Explanation = "1.000/6.000", IsCorrect = true },
                    new QuestionOption() { Explanation = "1.100/6.000" },
                    new QuestionOption() { Explanation = "1.200/5.000" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Adição com três frações com denominadores diferentes",
                Description = "Qual é o resultado da operação 15/5 + 25/10 + 20/15?",
                Difficulty = DifficultiesKind.Medium,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "40/3" },
                    new QuestionOption() { Explanation = "41/5" },
                    new QuestionOption() { Explanation = "42/9" },
                    new QuestionOption() { Explanation = "43/12" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas", IsCorrect = true  },
                }
            },
            new Question()
            {
                Title = "Subtração com três frações com denominadores diferentes",
                Description = "Qual é o resultado da operação 36/10 - 14/5 - 28/3?",
                Difficulty = DifficultiesKind.Medium,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "-128/15", IsCorrect = true },
                    new QuestionOption() { Explanation = "-125/17" },
                    new QuestionOption() { Explanation = "-124/13" },
                    new QuestionOption() { Explanation = "-130/12" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas"  },
                }
            },
            new Question()
            {
                Title = "Multiplicação com três frações com denominadores diferentes",
                Description = "Qual é o resultado da operação 17/10 * 14/8 * 8/3?",
                Difficulty = DifficultiesKind.Medium,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "119/13" },
                    new QuestionOption() { Explanation = "119/15", IsCorrect = true },
                    new QuestionOption() { Explanation = "119/17" },
                    new QuestionOption() { Explanation = "119/20" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas"  },
                }
            },
            new Question()
            {
                Title = "Divisão com três frações com denominadores diferentes",
                Description = "Qual é o resultado da operação 7/10 : 14/8 : 8/3?",
                Difficulty = DifficultiesKind.Medium,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "16/15", IsCorrect = true },
                    new QuestionOption() { Explanation = "20/15" },
                    new QuestionOption() { Explanation = "20/14" },
                    new QuestionOption() { Explanation = "20/13" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas"  },
                }
            },
            new Question()
            {
                Title = "Adição com quatro frações com denominadores iguais",
                Description = "Qual é o resultado da operação 7/10 + 14/10 + 8/10 + 3/10?",
                Difficulty = DifficultiesKind.Medium,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "24/10" },
                    new QuestionOption() { Explanation = "26/10" },
                    new QuestionOption() { Explanation = "28/10" },
                    new QuestionOption() { Explanation = "30/10" },
                    new QuestionOption() { Explanation = "32/10", IsCorrect = true },
                }
            },
            new Question()
            {
                Title = "Subtração com quatro frações com denominadores iguais",
                Description = "Qual é o resultado da operação 40/13 - 14/13 - 13/13 - 6/13?",
                Difficulty = DifficultiesKind.Medium,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "7/13", IsCorrect = true },
                    new QuestionOption() { Explanation = "14/13" },
                    new QuestionOption() { Explanation = "21/13" },
                    new QuestionOption() { Explanation = "28/13" },
                    new QuestionOption() { Explanation = "35/13" },
                }
            },
            


            // Hard questions
            new Question()
            {
                Title = "Adição com quatro frações com denominadores iguais",
                Description = "Qual é o resultado da operação 53/15 + 15/15 + 32/15 + 16/15?",
                Difficulty = DifficultiesKind.Hard,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "116/15", IsCorrect = true },
                    new QuestionOption() { Explanation = "103/15" },
                    new QuestionOption() { Explanation = "96/15" },
                    new QuestionOption() { Explanation = "98/15" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Subtração com quatro frações com denominadores iguais",
                Description = "Qual é o resultado da operação 95/15 - 32/15 - 13/15 - 16/15?",
                Difficulty = DifficultiesKind.Hard,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "16/15" },
                    new QuestionOption() { Explanation = "8/15" },
                    new QuestionOption() { Explanation = "4/15", IsCorrect = true },
                    new QuestionOption() { Explanation = "2/15" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Multiplicação com quatro frações com denominadores iguais",
                Description = "Qual é o resultado da operação 13/15 * 12/15 * 15/15 * 16/15?",
                Difficulty = DifficultiesKind.Hard,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "37.440/50.625", IsCorrect = true },
                    new QuestionOption() { Explanation = "36.345/50.625" },
                    new QuestionOption() { Explanation = "37.325/52.625" },
                    new QuestionOption() { Explanation = "34.395/51.625" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Divisão com quatro frações com denominadores iguais",
                Description = "Qual é o resultado da operação 4/20 : 7/20 : 13/20 : 16/20?",
                Difficulty = DifficultiesKind.Hard,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "28/345", IsCorrect = true },
                    new QuestionOption() { Explanation = "29/325" },
                    new QuestionOption() { Explanation = "30/325" },
                    new QuestionOption() { Explanation = "31/325" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas", IsCorrect = true },
                }
            },
            new Question()
            {
                Title = "Adição com quatro frações com denominadores diferentes",
                Description = "Qual é o resultado da operação 4/15 + 7/16 + 13/17 + 16/18?",
                Difficulty = DifficultiesKind.Hard,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "28859/12240", IsCorrect = true },
                    new QuestionOption() { Explanation = "23859/13240" },
                    new QuestionOption() { Explanation = "28559/14240" },
                    new QuestionOption() { Explanation = "23259/12540" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Subtração com quatro frações com denominadores diferentes",
                Description = "Qual é o resultado da operação 4/25 - 7/20 - 13/18 - 16/16?",
                Difficulty = DifficultiesKind.Hard,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "-1721/900", IsCorrect = true },
                    new QuestionOption() { Explanation = "-1621/870" },
                    new QuestionOption() { Explanation = "-1731/880" },
                    new QuestionOption() { Explanation = "-1761/890" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Multiplicação com quatro frações com denominadores diferentes",
                Description = "Qual é o resultado da operação 7/3 * 15/9 * 2/6 * 3/6?",
                Difficulty = DifficultiesKind.Hard,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "37/14" },
                    new QuestionOption() { Explanation = "32/24" },
                    new QuestionOption() { Explanation = "33/34" },
                    new QuestionOption() { Explanation = "35/54", IsCorrect = true },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Divisão com quatro frações com denominadores diferentes",
                Description = "Qual é o resultado da operação 23/5 : 32/3 : 9/5 : 9/7?",
                Difficulty = DifficultiesKind.Hard,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "483/800", IsCorrect = true },
                    new QuestionOption() { Explanation = "473/750" },
                    new QuestionOption() { Explanation = "463/760" },
                    new QuestionOption() { Explanation = "453/770" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Adição com cinco frações com denominadores iguais",
                Description = "Qual é o resultado da operação 5/5 + 93/5 + 38/5 + 35/5 + 83/5?",
                Difficulty = DifficultiesKind.Hard,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "254/5", IsCorrect = true },
                    new QuestionOption() { Explanation = "273/5" },
                    new QuestionOption() { Explanation = "293/5" },
                    new QuestionOption() { Explanation = "233/5" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Subtração com cinco frações com denominadores iguais",
                Description = "Qual é o resultado da operação 320/5 - 65/5 - 38/5 - 35/5 - 83/5?",
                Difficulty = DifficultiesKind.Hard,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "34/5" },
                    new QuestionOption() { Explanation = "65/5" },
                    new QuestionOption() { Explanation = "76/5" },
                    new QuestionOption() { Explanation = "99/5", IsCorrect = true },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
        };
    }
}
