using Gloomath.Models;
using System.Collections.Generic;

namespace Gloomath.Constants.Questions
{
    public static class FactorizationQuestions
    {
        public static List<Question> Questions = new List<Question>()
        {
            // Easy questions
            new Question()
            {
                Title = "Fatorização de um valor",
                Description = "Qual valor é equivalente a expressão 2^2 * 3?",
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "16" },
                    new QuestionOption() { Explanation = "12", IsCorrect = true },
                    new QuestionOption() { Explanation = "8" },
                    new QuestionOption() { Explanation = "4" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Fatorização de um valor",
                Description = "Qual valor é equivalente a expressão 2^4 * 3?",
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "60" },
                    new QuestionOption() { Explanation = "40" },
                    new QuestionOption() { Explanation = "32" },
                    new QuestionOption() { Explanation = "18" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas", IsCorrect = true },
                }
            },
            new Question()
            {
                Title = "Fatorização de um valor",
                Description = "Qual valor é equivalente a expressão 2^2 * 3^2?",
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "60" },
                    new QuestionOption() { Explanation = "34" },
                    new QuestionOption() { Explanation = "24" },
                    new QuestionOption() { Explanation = "18" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas", IsCorrect = true },
                }
            },
            new Question()
            {
                Title = "Fatorização de um valor",
                Description = "Qual valor é equivalente a expressão 2^2 * 2^2?",
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "32" },
                    new QuestionOption() { Explanation = "16", IsCorrect = true },
                    new QuestionOption() { Explanation = "8" },
                    new QuestionOption() { Explanation = "4" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Fatorização de um valor",
                Description = "Qual expressão é equivalente ao valor 16?",
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "2^3 * 2", IsCorrect = true },
                    new QuestionOption() { Explanation = "3^3" },
                    new QuestionOption() { Explanation = "2^5"},
                    new QuestionOption() { Explanation = "3^3 * 2" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Fatorização de um valor",
                Description = "Qual expressão é equivalente ao valor 32?",
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "2^3 * 2" },
                    new QuestionOption() { Explanation = "3^3" },
                    new QuestionOption() { Explanation = "2^5", IsCorrect = true },
                    new QuestionOption() { Explanation = "3^3 * 2" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Fatorização de um valor",
                Description = "Qual expressão é equivalente ao valor 50?",
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "2 * 5^2", IsCorrect = true },
                    new QuestionOption() { Explanation = "3^5" },
                    new QuestionOption() { Explanation = "4^3" },
                    new QuestionOption() { Explanation = "3^3 * 2" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Fatorização de um valor",
                Description = "Qual expressão é equivalente ao valor 94?",
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "2 * 44" },
                    new QuestionOption() { Explanation = "3^6" },
                    new QuestionOption() { Explanation = "4^4" },
                    new QuestionOption() { Explanation = "3^3 * 4^2" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas", IsCorrect = true },
                }
            },
            new Question()
            {
                Title = "Fatorização de um valor",
                Description = "Qual expressão é equivalente ao valor 24?",
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "2^3 * 3", IsCorrect = true },
                    new QuestionOption() { Explanation = "3^3" },
                    new QuestionOption() { Explanation = "4^2 * 2" },
                    new QuestionOption() { Explanation = "2^3 * 4" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Fatorização de um valor",
                Description = "Qual expressão é equivalente ao valor 64?",
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "2^3" },
                    new QuestionOption() { Explanation = "3^4" },
                    new QuestionOption() { Explanation = "2^6 * 2" },
                    new QuestionOption() { Explanation = "2^6", IsCorrect = true },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },



            // Medium questions
            new Question()
            {
                Title = "Fatorização de um valor",
                Description = "Qual valor é equivalente a expressão 2^2 * 3 * 13?",
                Difficulty = DifficultiesKind.Medium,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "183" },
                    new QuestionOption() { Explanation = "156", IsCorrect = true },
                    new QuestionOption() { Explanation = "123" },
                    new QuestionOption() { Explanation = "95" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Fatorização de um valor",
                Description = "Qual valor é equivalente a expressão 2 * 97",
                Difficulty = DifficultiesKind.Medium,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "234" },
                    new QuestionOption() { Explanation = "203" },
                    new QuestionOption() { Explanation = "194", IsCorrect = true  },
                    new QuestionOption() { Explanation = "154" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Fatorização de um valor",
                Description = "Qual valor é equivalente a expressão 7 * 19?",
                Difficulty = DifficultiesKind.Medium,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "175" },
                    new QuestionOption() { Explanation = "154" },
                    new QuestionOption() { Explanation = "143" },
                    new QuestionOption() { Explanation = "133", IsCorrect = true },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Fatorização de um valor",
                Description = "Qual valor é equivalente a expressão 2 * 3^2 * 13?",
                Difficulty = DifficultiesKind.Medium,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "285" },
                    new QuestionOption() { Explanation = "253" },
                    new QuestionOption() { Explanation = "234", IsCorrect = true },
                    new QuestionOption() { Explanation = "195" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Fatorização de um valor",
                Description = "Qual valor é equivalente a expressão 7^3?",
                Difficulty = DifficultiesKind.Medium,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "345" },
                    new QuestionOption() { Explanation = "304" },
                    new QuestionOption() { Explanation = "285" },
                    new QuestionOption() { Explanation = "253" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas", IsCorrect = true },
                }
            },
            new Question()
            {
                Title = "Fatorização de um valor",
                Description = "Qual expressão é equivalente ao valor 452?",
                Difficulty = DifficultiesKind.Medium,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "2^2 * 113", IsCorrect = true },
                    new QuestionOption() { Explanation = "2 * 115" },
                    new QuestionOption() { Explanation = "3^9 * 10" },
                    new QuestionOption() { Explanation = "4^2 * 102" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Fatorização de um valor",
                Description = "Qual expressão é equivalente ao valor 742?",
                Difficulty = DifficultiesKind.Medium,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "2 * 7 * 53", IsCorrect = true },
                    new QuestionOption() { Explanation = "2 * 330" },
                    new QuestionOption() { Explanation = "3^4 * 4" },
                    new QuestionOption() { Explanation = "4^2 * 102" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Fatorização de um valor",
                Description = "Qual expressão é equivalente ao valor 432?",
                Difficulty = DifficultiesKind.Medium,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "2^4 * 3^2 * 3" },
                    new QuestionOption() { Explanation = "2^4 * 3^5" },
                    new QuestionOption() { Explanation = "2^6 * 3^2" },
                    new QuestionOption() { Explanation = "2^4 * 3^3", IsCorrect = true },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Fatorização de um valor",
                Description = "Qual expressão é equivalente ao valor 464?",
                Difficulty = DifficultiesKind.Medium,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "2^4 * 23" },
                    new QuestionOption() { Explanation = "2^6 * 3" },
                    new QuestionOption() { Explanation = "2^4 * 29", IsCorrect = true },
                    new QuestionOption() { Explanation = "2^7 * 2" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Fatorização de um valor",
                Description = "Qual expressão é equivalente ao valor 464?",
                Difficulty = DifficultiesKind.Medium,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "2 * 3^2 * 13", IsCorrect = true },
                    new QuestionOption() { Explanation = "2^3 * 3^4" },
                    new QuestionOption() { Explanation = "3^2 * 3^2" },
                    new QuestionOption() { Explanation = "2^3 * 2" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            


            // Hard questions
            new Question()
            {
                Title = "Fatorização de um valor",
                Description = "Qual valor é equivalente a expressão 2^6 * 3 * 7?",
                Difficulty = DifficultiesKind.Hard,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "1503" },
                    new QuestionOption() { Explanation = "1454" },
                    new QuestionOption() { Explanation = "1394" },
                    new QuestionOption() { Explanation = "1344", IsCorrect = true },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Fatorização de um valor",
                Description = "Qual valor é equivalente a expressão 37^2?",
                Difficulty = DifficultiesKind.Hard,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "1543" },
                    new QuestionOption() { Explanation = "1453" },
                    new QuestionOption() { Explanation = "1394" },
                    new QuestionOption() { Explanation = "1344" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas", IsCorrect = true },
                }
            },
            new Question()
            {
                Title = "Fatorização de um valor",
                Description = "Qual valor é equivalente a expressão 5 * 11 * 43?",
                Difficulty = DifficultiesKind.Hard,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "2593" },
                    new QuestionOption() { Explanation = "2365", IsCorrect = true },
                    new QuestionOption() { Explanation = "2103" },
                    new QuestionOption() { Explanation = "1934" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Fatorização de um valor",
                Description = "Qual valor é equivalente a expressão 13 * 211?",
                Difficulty = DifficultiesKind.Hard,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "2345" },
                    new QuestionOption() { Explanation = "2545" },
                    new QuestionOption() { Explanation = "2743", IsCorrect = true },
                    new QuestionOption() { Explanation = "2945" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Fatorização de um valor",
                Description = "Qual valor é equivalente a expressão 2 * 3 * 7 * 61?",
                Difficulty = DifficultiesKind.Hard,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "2934" },
                    new QuestionOption() { Explanation = "2764" },
                    new QuestionOption() { Explanation = "2562", IsCorrect = true },
                    new QuestionOption() { Explanation = "2341" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Fatorização de um valor",
                Description = "Qual expressão é equivalente ao valor 2345?",
                Difficulty = DifficultiesKind.Hard,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "5 * 7 * 68" },
                    new QuestionOption() { Explanation = "9 * 3 * 23" },
                    new QuestionOption() { Explanation = "98 * 5" },
                    new QuestionOption() { Explanation = "2^6 * 4" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas", IsCorrect = true  },
                }
            },
            new Question()
            {
                Title = "Fatorização de um valor",
                Description = "Qual expressão é equivalente ao valor 2934?",
                Difficulty = DifficultiesKind.Hard,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "5 * 32 * 3" },
                    new QuestionOption() { Explanation = "2 * 3^2 * 163", IsCorrect = true },
                    new QuestionOption() { Explanation = "3^6 * 54" },
                    new QuestionOption() { Explanation = "2^9 * 2^3" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Fatorização de um valor",
                Description = "Qual expressão é equivalente ao valor 3456?",
                Difficulty = DifficultiesKind.Hard,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "6^4 * 3" },
                    new QuestionOption() { Explanation = "9^3 * 2" },
                    new QuestionOption() { Explanation = "3^4 * 2 * 4^2" },
                    new QuestionOption() { Explanation = "2^9 * 2^3" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas", IsCorrect = true },
                }
            },
            new Question()
            {
                Title = "Fatorização de um valor",
                Description = "Qual expressão é equivalente ao valor 5624?",
                Difficulty = DifficultiesKind.Hard,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "2^3 * 19 * 37", IsCorrect = true },
                    new QuestionOption() { Explanation = "9^3 * 4" },
                    new QuestionOption() { Explanation = "3^4 * 4 * 4^2" },
                    new QuestionOption() { Explanation = "4^7 * 2" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Fatorização de um valor",
                Description = "Qual expressão é equivalente ao valor 10328?",
                Difficulty = DifficultiesKind.Hard,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "2^3 * 1291", IsCorrect = true },
                    new QuestionOption() { Explanation = "9^6" },
                    new QuestionOption() { Explanation = "2^4 * 3^6 * 3" },
                    new QuestionOption() { Explanation = "4^6 * 9^3" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
        };
    }
}
