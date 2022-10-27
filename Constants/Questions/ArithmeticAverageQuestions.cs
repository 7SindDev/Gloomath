using Gloomath.Models;
using System.Collections.Generic;

namespace Gloomath.Constants.Questions
{
    public class ArithmeticAverageQuestions
    {
        public static List<Question> Questions = new List<Question>()
        {
            // Easy questions
            new Question()
            {
                Title = "Média aritmética de dois valores",
                Description = "Qual é a média aritmética de 20 e 10?",
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "20" },
                    new QuestionOption() { Explanation = "15", IsCorrect = true },
                    new QuestionOption() { Explanation = "10" },
                    new QuestionOption() { Explanation = "5" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Média aritmética de dois valores",
                Description = "Qual é a média aritmética de 30 e 10?",
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "20", IsCorrect = true },
                    new QuestionOption() { Explanation = "15" },
                    new QuestionOption() { Explanation = "10" },
                    new QuestionOption() { Explanation = "5" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Média aritmética de dois valores",
                Description = "Qual é a média aritmética de 30 e 50?",
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "40", IsCorrect = true },
                    new QuestionOption() { Explanation = "35" },
                    new QuestionOption() { Explanation = "30" },
                    new QuestionOption() { Explanation = "25" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Média aritmética de dois valores",
                Description = "Qual é a média aritmética de 15 e 25?",
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "20", IsCorrect = true },
                    new QuestionOption() { Explanation = "15" },
                    new QuestionOption() { Explanation = "10" },
                    new QuestionOption() { Explanation = "5" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Média aritmética de dois valores",
                Description = "Qual é a média aritmética de 20 e 30?",
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "5" },
                    new QuestionOption() { Explanation = "10" },
                    new QuestionOption() { Explanation = "15" },
                    new QuestionOption() { Explanation = "20" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas", IsCorrect = true },
                }
            },
            new Question()
            {
                Title = "Média aritmética de dois valores",
                Description = "Qual é a média aritmética de 50 e 20?",
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "50" },
                    new QuestionOption() { Explanation = "45" },
                    new QuestionOption() { Explanation = "40" },
                    new QuestionOption() { Explanation = "35", IsCorrect = true },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Média aritmética de dois valores",
                Description = "Qual é a média aritmética de 90 e 30?",
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "50" },
                    new QuestionOption() { Explanation = "55" },
                    new QuestionOption() { Explanation = "60", IsCorrect = true },
                    new QuestionOption() { Explanation = "65" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Média aritmética de dois valores",
                Description = "Qual é a média aritmética de 120 e 50?",
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "90" },
                    new QuestionOption() { Explanation = "85", IsCorrect = true },
                    new QuestionOption() { Explanation = "80" },
                    new QuestionOption() { Explanation = "75" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Média aritmética de dois valores",
                Description = "Qual é a média aritmética de 150 e 50?",
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "100", IsCorrect = true },
                    new QuestionOption() { Explanation = "95" },
                    new QuestionOption() { Explanation = "90" },
                    new QuestionOption() { Explanation = "85" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Média aritmética de dois valores",
                Description = "Qual é a média aritmética de 250 e 100?",
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "200" },
                    new QuestionOption() { Explanation = "175", IsCorrect = true },
                    new QuestionOption() { Explanation = "150" },
                    new QuestionOption() { Explanation = "125" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },



            // Medium questions
            new Question()
            {
                Title = "Média aritmética de três valores",
                Description = "Qual é a média aritmética de 250, 100 e 25?",
                Difficulty = DifficultiesKind.Medium,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "200" },
                    new QuestionOption() { Explanation = "175" },
                    new QuestionOption() { Explanation = "150" },
                    new QuestionOption() { Explanation = "125", IsCorrect = true },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Média aritmética de três valores",
                Description = "Qual é a média aritmética de 150, 100 e 50?",
                Difficulty = DifficultiesKind.Medium,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "200" },
                    new QuestionOption() { Explanation = "175" },
                    new QuestionOption() { Explanation = "150" },
                    new QuestionOption() { Explanation = "125" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas", IsCorrect = true },
                }
            },
            new Question()
            {
                Title = "Média aritmética de três valores",
                Description = "Qual é a média aritmética de 500, 250 e 75?",
                Difficulty = DifficultiesKind.Medium,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "200" },
                    new QuestionOption() { Explanation = "175" },
                    new QuestionOption() { Explanation = "150" },
                    new QuestionOption() { Explanation = "125" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas", IsCorrect = true },
                }
            },
            new Question()
            {
                Title = "Média aritmética de três valores",
                Description = "Qual é a média aritmética de 750, 90 e 60?",
                Difficulty = DifficultiesKind.Medium,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "350" },
                    new QuestionOption() { Explanation = "325" },
                    new QuestionOption() { Explanation = "300", IsCorrect = true },
                    new QuestionOption() { Explanation = "275" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Média aritmética de três valores",
                Description = "Qual é a média aritmética de 350, 150 e 25?",
                Difficulty = DifficultiesKind.Medium,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "250" },
                    new QuestionOption() { Explanation = "225" },
                    new QuestionOption() { Explanation = "200" },
                    new QuestionOption() { Explanation = "175", IsCorrect = true },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Média aritmética de três valores",
                Description = "Qual é a média aritmética de 850, 350 e 150?",
                Difficulty = DifficultiesKind.Medium,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "550" },
                    new QuestionOption() { Explanation = "500" },
                    new QuestionOption() { Explanation = "450", IsCorrect = true },
                    new QuestionOption() { Explanation = "400" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Média aritmética de três valores",
                Description = "Qual é a média aritmética de 650, 370 e 150?",
                Difficulty = DifficultiesKind.Medium,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "550" },
                    new QuestionOption() { Explanation = "500" },
                    new QuestionOption() { Explanation = "450" },
                    new QuestionOption() { Explanation = "400" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas", IsCorrect = true },
                }
            },
            new Question()
            {
                Title = "Média aritmética de três valores",
                Description = "Qual é a média aritmética de 545, 350 e 260?",
                Difficulty = DifficultiesKind.Medium,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "550" },
                    new QuestionOption() { Explanation = "500" },
                    new QuestionOption() { Explanation = "450" },
                    new QuestionOption() { Explanation = "400" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas", IsCorrect = true },
                }
            },
            new Question()
            {
                Title = "Média aritmética de três valores",
                Description = "Qual é a média aritmética de 650, 350 e 50?",
                Difficulty = DifficultiesKind.Medium,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "500" },
                    new QuestionOption() { Explanation = "450" },
                    new QuestionOption() { Explanation = "400" },
                    new QuestionOption() { Explanation = "350", IsCorrect = true },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Média aritmética de três valores",
                Description = "Qual é a média aritmética de 850, 400 e 220?",
                Difficulty = DifficultiesKind.Medium,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "500" },
                    new QuestionOption() { Explanation = "490" },
                    new QuestionOption() { Explanation = "480", IsCorrect = true },
                    new QuestionOption() { Explanation = "370" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            


            // Hard questions
            new Question()
            {
                Title = "Média aritmética de quatro valores",
                Description = "Qual é a média aritmética de 850, 400, 220 e 510?",
                Difficulty = DifficultiesKind.Hard,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "500" },
                    new QuestionOption() { Explanation = "495" },
                    new QuestionOption() { Explanation = "490", IsCorrect = true },
                    new QuestionOption() { Explanation = "485" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Média aritmética de quatro valores",
                Description = "Qual é a média aritmética de 350, 400, 220 e 250?",
                Difficulty = DifficultiesKind.Hard,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "325" },
                    new QuestionOption() { Explanation = "320" },
                    new QuestionOption() { Explanation = "315" },
                    new QuestionOption() { Explanation = "310" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas", IsCorrect = true },
                }
            },
            new Question()
            {
                Title = "Média aritmética de quatro valores",
                Description = "Qual é a média aritmética de 400, 300, 200 e 100?",
                Difficulty = DifficultiesKind.Hard,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "325" },
                    new QuestionOption() { Explanation = "300" },
                    new QuestionOption() { Explanation = "275" },
                    new QuestionOption() { Explanation = "250", IsCorrect = true },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Média aritmética de quatro valores",
                Description = "Qual é a média aritmética de 500, 400, 300 e 200?",
                Difficulty = DifficultiesKind.Hard,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "350", IsCorrect = true },
                    new QuestionOption() { Explanation = "325" },
                    new QuestionOption() { Explanation = "300" },
                    new QuestionOption() { Explanation = "275" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Média aritmética de quatro valores",
                Description = "Qual é a média aritmética de 500, 200, 350 e 150?",
                Difficulty = DifficultiesKind.Hard,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "350" },
                    new QuestionOption() { Explanation = "325" },
                    new QuestionOption() { Explanation = "300", IsCorrect = true },
                    new QuestionOption() { Explanation = "275" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Média aritmética de quatro valores",
                Description = "Qual é a média aritmética de 500, 200, 50 e 150?",
                Difficulty = DifficultiesKind.Hard,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "350" },
                    new QuestionOption() { Explanation = "325" },
                    new QuestionOption() { Explanation = "300" },
                    new QuestionOption() { Explanation = "275" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas", IsCorrect = true },
                }
            },
            new Question()
            {
                Title = "Média aritmética de quatro valores",
                Description = "Qual é a média aritmética de 150, 800, 250 e 300?",
                Difficulty = DifficultiesKind.Hard,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "375", IsCorrect = true },
                    new QuestionOption() { Explanation = "350" },
                    new QuestionOption() { Explanation = "325" },
                    new QuestionOption() { Explanation = "300" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas"},
                }
            },
            new Question()
            {
                Title = "Média aritmética de quatro valores",
                Description = "Qual é a média aritmética de 350, 300, 250 e 100?",
                Difficulty = DifficultiesKind.Hard,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "275" },
                    new QuestionOption() { Explanation = "250", IsCorrect = true },
                    new QuestionOption() { Explanation = "225" },
                    new QuestionOption() { Explanation = "200" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas"},
                }
            },
            new Question()
            {
                Title = "Média aritmética de quatro valores",
                Description = "Qual é a média aritmética de 450, 230, 505 e 415?",
                Difficulty = DifficultiesKind.Hard,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "350" },
                    new QuestionOption() { Explanation = "375" },
                    new QuestionOption() { Explanation = "400", IsCorrect = true },
                    new QuestionOption() { Explanation = "425" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas"},
                }
            },
            new Question()
            {
                Title = "Média aritmética de quatro valores",
                Description = "Qual é a média aritmética de 500, 300, 400 e 1060?",
                Difficulty = DifficultiesKind.Hard,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "600" },
                    new QuestionOption() { Explanation = "565", IsCorrect = true },
                    new QuestionOption() { Explanation = "535" },
                    new QuestionOption() { Explanation = "500" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas"},
                }
            },
        };
    }
}
