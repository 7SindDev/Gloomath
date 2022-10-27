using Gloomath.Models;
using System.Collections.Generic;
using System.Windows.Documents;

namespace Gloomath.Constants.Questions
{
    public static class ArithmeticOperationsQuestions
    {
        public static List<Question> Questions = new List<Question>()
        {
            // Easy questions
            new Question()
            {
                Title = "Adição",
                Description = "Qual é o resultado da operação 5 + 4?",
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "8" },
                    new QuestionOption() { Explanation = "9", IsCorrect = true },
                    new QuestionOption() { Explanation = "7" },
                    new QuestionOption() { Explanation = "6" },
                    new QuestionOption() { Explanation = "10" },
                }
            },
            new Question()
            {
                Title = "Adição com décimos",
                Description = "Qual é o resultado da operação 20 + 32?",
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "51" },
                    new QuestionOption() { Explanation = "52", IsCorrect = true },
                    new QuestionOption() { Explanation = "62" },
                    new QuestionOption() { Explanation = "53" },
                    new QuestionOption() { Explanation = "54" },
                }
            },
            new Question()
            {
                Title = "Subtração",
                Description = "Qual é o resultado da diferença de 9 e 4?",
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "5", IsCorrect = true },
                    new QuestionOption() { Explanation = "4" },
                    new QuestionOption() { Explanation = "3" },
                    new QuestionOption() { Explanation = "6" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Subtração com décimos",
                Description = "Qual é o resultado da diferença de 25 e 11?",
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "15" },
                    new QuestionOption() { Explanation = "16" },
                    new QuestionOption() { Explanation = "14", IsCorrect = true },
                    new QuestionOption() { Explanation = "13" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Multiplicação",
                Description = "Qual é o resultado do produto de 5 e 3?",
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "16" },
                    new QuestionOption() { Explanation = "14" },
                    new QuestionOption() { Explanation = "13" },
                    new QuestionOption() { Explanation = "15", IsCorrect = true },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Multiplicação com décimos",
                Description = "Qual é o resultado do produto de 10 e 15?",
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "150", IsCorrect = true },
                    new QuestionOption() { Explanation = "155" },
                    new QuestionOption() { Explanation = "160" },
                    new QuestionOption() { Explanation = "165" },
                    new QuestionOption() { Explanation = "170" },
                }
            },
            new Question()
            {
                Title = "Divisão",
                Description = "Qual é o resultado do resto de 30 e 5?",
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "3" },
                    new QuestionOption() { Explanation = "4" },
                    new QuestionOption() { Explanation = "6", IsCorrect = true },
                    new QuestionOption() { Explanation = "7" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Divisão com décimos",
                Description = "Qual é o resultado do resto de 30 e 15?",
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "3" },
                    new QuestionOption() { Explanation = "4" },
                    new QuestionOption() { Explanation = "6" },
                    new QuestionOption() { Explanation = "7" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas", IsCorrect = true },
                }
            },
            new Question()
            {
                Title = "Adição com centésimos",
                Description = "Qual é o resultado da soma de 155 e 105?",
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "170" },
                    new QuestionOption() { Explanation = "270" },
                    new QuestionOption() { Explanation = "260", IsCorrect = true },
                    new QuestionOption() { Explanation = "265" },
                    new QuestionOption() { Explanation = "255" },
                }
            },
            new Question()
            {
                Title = "Subtração com centésimos",
                Description = "Qual é o resultado da soma de 305 e 105?",
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "200", IsCorrect = true },
                    new QuestionOption() { Explanation = "190" },
                    new QuestionOption() { Explanation = "210" },
                    new QuestionOption() { Explanation = "205" },
                    new QuestionOption() { Explanation = "195" },
                }
            },



            // Medium questions
            new Question()
            {
                Title = "Adição com centésimos",
                Description = "Qual é o resultado da soma de 305 e 105?",
                Difficulty = DifficultiesKind.Medium,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "415" },
                    new QuestionOption() { Explanation = "410", IsCorrect = true  },
                    new QuestionOption() { Explanation = "405" },
                    new QuestionOption() { Explanation = "400" },
                    new QuestionOption() { Explanation = "395" },
                }
            },
            new Question()
            {
                Title = "Adição com milésimos",
                Description = "Qual é o resultado da soma de 1354 e 1646?",
                Difficulty = DifficultiesKind.Medium,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "2950" },
                    new QuestionOption() { Explanation = "2960" },
                    new QuestionOption() { Explanation = "2975" },
                    new QuestionOption() { Explanation = "3005" },
                    new QuestionOption() { Explanation = "3000", IsCorrect = true },
                }
            },
            new Question()
            {
                Title = "Subtração com centésimos",
                Description = "Qual é o resultado da diferença de 502 e 301?",
                Difficulty = DifficultiesKind.Medium,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "200" },
                    new QuestionOption() { Explanation = "202" },
                    new QuestionOption() { Explanation = "201", IsCorrect = true },
                    new QuestionOption() { Explanation = "205" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Subtração com milésimos",
                Description = "Qual é o resultado da diferença de 1545 e 1934?",
                Difficulty = DifficultiesKind.Medium,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "-389", IsCorrect = true  },
                    new QuestionOption() { Explanation = "-384" },
                    new QuestionOption() { Explanation = "-398" },
                    new QuestionOption() { Explanation = "-386" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Multiplicação com centésimos",
                Description = "Qual é o resultado da produto de 103 e 205?",
                Difficulty = DifficultiesKind.Medium,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "21.120" },
                    new QuestionOption() { Explanation = "21.115", IsCorrect = true  },
                    new QuestionOption() { Explanation = "21.150" },
                    new QuestionOption() { Explanation = "21.160" },
                    new QuestionOption() { Explanation = "21.200" },
                }
            },
            new Question()
            {
                Title = "Multiplicação com milésimos",
                Description = "Qual é o resultado da produto de 1000 e 250?",
                Difficulty = DifficultiesKind.Medium,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "250.050" },
                    new QuestionOption() { Explanation = "250.010" },
                    new QuestionOption() { Explanation = "250.100" },
                    new QuestionOption() { Explanation = "250.200" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas", IsCorrect = true  },
                }
            },
            new Question()
            {
                Title = "Divisão com centésimos",
                Description = "Qual é o resultado do resto de 900 e 250?",
                Difficulty = DifficultiesKind.Medium,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "3,2" },
                    new QuestionOption() { Explanation = "3,4" },
                    new QuestionOption() { Explanation = "3,6", IsCorrect = true },
                    new QuestionOption() { Explanation = "3,8" },
                    new QuestionOption() { Explanation = "4"  },
                }
            },
            new Question()
            {
                Title = "Divisão com milésimos",
                Description = "Qual é o resultado do resto de 3850 e 2000?",
                Difficulty = DifficultiesKind.Medium,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "2,25"  },
                    new QuestionOption() { Explanation = "2" },
                    new QuestionOption() { Explanation = "1,975" },
                    new QuestionOption() { Explanation = "1,950" },
                    new QuestionOption() { Explanation = "1,925", IsCorrect = true },
                }
            },
            new Question()
            {
                Title = "Divisão com milésimos",
                Description = "Qual é o resultado do resto de 3850 e 2000?",
                Difficulty = DifficultiesKind.Medium,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "2,25"  },
                    new QuestionOption() { Explanation = "2" },
                    new QuestionOption() { Explanation = "1,975" },
                    new QuestionOption() { Explanation = "1,950" },
                    new QuestionOption() { Explanation = "1,925", IsCorrect = true },
                }
            },
            new Question()
            {
                Title = "Multiplicação com milésimos",
                Description = "Qual é o resultado do produto de 1000 e 5000?",
                Difficulty = DifficultiesKind.Medium,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "5.000.100" },
                    new QuestionOption() { Explanation = "5.000.050" },
                    new QuestionOption() { Explanation = "5.000.000", IsCorrect = true  },
                    new QuestionOption() { Explanation = "5.001.000" },
                    new QuestionOption() { Explanation = "5.005.000" },
                }
            },



            // Hard questions
            new Question()
            {
                Title = "Adição com três centésimos",
                Description = "Qual é o resultado da soma de 103 + 304 + 403?",
                Difficulty = DifficultiesKind.Hard,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "800" },
                    new QuestionOption() { Explanation = "805" },
                    new QuestionOption() { Explanation = "810", IsCorrect = true  },
                    new QuestionOption() { Explanation = "815" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Subtração com três centésimos",
                Description = "Calcule a diferença de 304, 203 e 125",
                Difficulty = DifficultiesKind.Hard,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "20" },
                    new QuestionOption() { Explanation = "5" },
                    new QuestionOption() { Explanation = "-5"  },
                    new QuestionOption() { Explanation = "-20" },
                    new QuestionOption() { Explanation = "-24", IsCorrect = true },
                }
            },
            new Question()
            {
                Title = "Multiplicação com três centésimos",
                Description = "Calcule o produto de 100, 105 e 110",
                Difficulty = DifficultiesKind.Hard,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "1.085.000" },
                    new QuestionOption() { Explanation = "1.100.000" },
                    new QuestionOption() { Explanation = "1.115.000", IsCorrect = true  },
                    new QuestionOption() { Explanation = "1.150.000" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Divisão com três centésimos",
                Description = "Calcule o resto de 1000, 250 e 2",
                Difficulty = DifficultiesKind.Hard,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "8" },
                    new QuestionOption() { Explanation = "6" },
                    new QuestionOption() { Explanation = "4" },
                    new QuestionOption() { Explanation = "2", IsCorrect = true  },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Adição com três milésimos",
                Description = "Calcule a soma de 1050 + 1258 + 3022",
                Difficulty = DifficultiesKind.Hard,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "4.330" },
                    new QuestionOption() { Explanation = "5.330", IsCorrect = true },
                    new QuestionOption() { Explanation = "5.450" },
                    new QuestionOption() { Explanation = "5.550"  },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Subtração com três milésimos",
                Description = "Calcule a diferença de 5000, 3450 e 1000",
                Difficulty = DifficultiesKind.Hard,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "650" },
                    new QuestionOption() { Explanation = "600" },
                    new QuestionOption() { Explanation = "550", IsCorrect = true  },
                    new QuestionOption() { Explanation = "500"  },
                    new QuestionOption() { Explanation = "450" },
                }
            },
            new Question()
            {
                Title = "Multiplicação com três milésimos",
                Description = "Calcule o produto de 1000, 1000 e 500",
                Difficulty = DifficultiesKind.Hard,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "450.000.000" },
                    new QuestionOption() { Explanation = "460.000.000" },
                    new QuestionOption() { Explanation = "470.000.000" },
                    new QuestionOption() { Explanation = "480.000.000"  },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas", IsCorrect = true },
                }
            },
            new Question()
            {
                Title = "Divisão com três milésimos",
                Description = "Calcule o resto de 9000, 3000 e 1000",
                Difficulty = DifficultiesKind.Hard,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "0,03" },
                    new QuestionOption() { Explanation = "0,0003" },
                    new QuestionOption() { Explanation = "0,00003" },
                    new QuestionOption() { Explanation = "0,003", IsCorrect = true  },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Adição com quatro centésimos",
                Description = "Calcule a soma de 395 + 455 + 490 + 950",
                Difficulty = DifficultiesKind.Hard,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "2.290", IsCorrect = true   },
                    new QuestionOption() { Explanation = "2.300" },
                    new QuestionOption() { Explanation = "2.310" },
                    new QuestionOption() { Explanation = "2.320" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Subtração com quatro centésimos",
                Description = "Calcule a diferença de 502, 300, 20, e 75",
                Difficulty = DifficultiesKind.Hard,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "105" },
                    new QuestionOption() { Explanation = "107", IsCorrect = true },
                    new QuestionOption() { Explanation = "109" },
                    new QuestionOption() { Explanation = "111" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            }
        };
    }
}
