using Gloomath.Models;
using System.Collections.Generic;

namespace Gloomath.Constants.Questions
{
    public class ThermodynamicQuestions
    {
        public static List<Question> Questions = new List<Question>()
        {
            // Easy questions
            new Question()
            {
                Title = "Conversão de Celsius para Fahrenheit",
                Description = "Qual é o valor de 30°C em Fahrenheit?",
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "96°F" },
                    new QuestionOption() { Explanation = "86°F", IsCorrect = true },
                    new QuestionOption() { Explanation = "76°F" },
                    new QuestionOption() { Explanation = "66°F" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Conversão de Celsius para Fahrenheit",
                Description = "Qual é o valor de 45°C em Fahrenheit?",
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "73,4°F" },
                    new QuestionOption() { Explanation = "123°F" },
                    new QuestionOption() { Explanation = "113°F", IsCorrect = true },
                    new QuestionOption() { Explanation = "98°F" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Conversão de Celsius para Fahrenheit",
                Description = "Qual é o valor de 23°C em Fahrenheit?",
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "73,4°F", IsCorrect = true },
                    new QuestionOption() { Explanation = "123°F" },
                    new QuestionOption() { Explanation = "113°F" },
                    new QuestionOption() { Explanation = "98°F" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Conversão de Celsius para Kelvin",
                Description = "Qual é o valor de 54°C em Kelvin?",
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "327,15°K", IsCorrect = true },
                    new QuestionOption() { Explanation = "346,4°K" },
                    new QuestionOption() { Explanation = "385,4°K" },
                    new QuestionOption() { Explanation = "403,2°K" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Conversão de Celsius para Kelvin",
                Description = "Qual é o valor de 23°C em Kelvin?",
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "394,2°K" },
                    new QuestionOption() { Explanation = "296,15°K", IsCorrect = true },
                    new QuestionOption() { Explanation = "286,34°K" },
                    new QuestionOption() { Explanation = "256°K" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Conversão de Celsius para Kelvin",
                Description = "Qual é o valor de 76°C em Kelvin?",
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "23,2°K" },
                    new QuestionOption() { Explanation = "76,4°K" },
                    new QuestionOption() { Explanation = "134,8°K" },
                    new QuestionOption() { Explanation = "349,15°K", IsCorrect = true },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Conversão de Fahrenheit para Kelvin",
                Description = "Qual é o valor de 76°F em Kelvin?",
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "297,594°K", IsCorrect = true },
                    new QuestionOption() { Explanation = "303,423°K" },
                    new QuestionOption() { Explanation = "342,321°K" },
                    new QuestionOption() { Explanation = "394,231°K" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Conversão de Fahrenheit para Kelvin",
                Description = "Qual é o valor de 43°F em Kelvin?",
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "254,194°K" },
                    new QuestionOption() { Explanation = "268,423°K" },
                    new QuestionOption() { Explanation = "298,521°K" },
                    new QuestionOption() { Explanation = "346,231°K" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas", IsCorrect = true },
                }
            },
            new Question()
            {
                Title = "Conversão de Fahrenheit para Kelvin",
                Description = "Qual é o valor de 15°F em Kelvin?",
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "235,134°K" },
                    new QuestionOption() { Explanation = "245,323°K" },
                    new QuestionOption() { Explanation = "258,521°K" },
                    new QuestionOption() { Explanation = "263,706°K", IsCorrect = true },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Conversão de Fahrenheit para Kelvin",
                Description = "Qual é o valor de 32°F em Celsius?",
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "4°C" },
                    new QuestionOption() { Explanation = "3°C" },
                    new QuestionOption() { Explanation = "2°C" },
                    new QuestionOption() { Explanation = "1°C" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas", IsCorrect = true },
                }
            },



            // Medium questions
            new Question()
            {
                Title = "Conversão de Celsius para Fahrenheit",
                Description = "Qual é o valor de 65°C em Fahrenheit?",
                Difficulty = DifficultiesKind.Medium,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "165°F" },
                    new QuestionOption() { Explanation = "155°F" },
                    new QuestionOption() { Explanation = "149°F", IsCorrect = true },
                    new QuestionOption() { Explanation = "125°F" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Conversão de Celsius para Fahrenheit",
                Description = "Qual é o valor de 35°C em Fahrenheit?",
                Difficulty = DifficultiesKind.Medium,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "132°F" },
                    new QuestionOption() { Explanation = "102°F" },
                    new QuestionOption() { Explanation = "95°F", IsCorrect = true },
                    new QuestionOption() { Explanation = "56°F" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Conversão de Celsius para Fahrenheit",
                Description = "Qual é o valor de 73°C em Fahrenheit?",
                Difficulty = DifficultiesKind.Medium,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "163,4°F", IsCorrect = true },
                    new QuestionOption() { Explanation = "184,7°F" },
                    new QuestionOption() { Explanation = "190°F" },
                    new QuestionOption() { Explanation = "203°F" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Conversão de Celsius para Kelvin",
                Description = "Qual é o valor de 52°C em Kelvin?",
                Difficulty = DifficultiesKind.Medium,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "325,15°K", IsCorrect = true },
                    new QuestionOption() { Explanation = "285,2°K" },
                    new QuestionOption() { Explanation = "254,4°K" },
                    new QuestionOption() { Explanation = "203°K" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Conversão de Celsius para Kelvin",
                Description = "Qual é o valor de 22°C em Kelvin?",
                Difficulty = DifficultiesKind.Medium,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "295,15°K", IsCorrect = true },
                    new QuestionOption() { Explanation = "302,23°K" },
                    new QuestionOption() { Explanation = "316,49°K" },
                    new QuestionOption() { Explanation = "334,27°K" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Conversão de Celsius para Kelvin",
                Description = "Qual é o valor de 2°C em Kelvin?",
                Difficulty = DifficultiesKind.Medium,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "275,15°K", IsCorrect = true },
                    new QuestionOption() { Explanation = "294,23°K" },
                    new QuestionOption() { Explanation = "313,49°K" },
                    new QuestionOption() { Explanation = "334,27°K" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Conversão de Fahrenheit para Kelvin",
                Description = "Qual é o valor de 32°F em Kelvin?",
                Difficulty = DifficultiesKind.Medium,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "324,23°K" },
                    new QuestionOption() { Explanation = "301,54°K" },
                    new QuestionOption() { Explanation = "273,15°K", IsCorrect = true },
                    new QuestionOption() { Explanation = "255,93°K" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Conversão de Fahrenheit para Kelvin",
                Description = "Qual é o valor de 75°F em Kelvin?",
                Difficulty = DifficultiesKind.Medium,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "321,32°K" },
                    new QuestionOption() { Explanation = "301,21°K" },
                    new QuestionOption() { Explanation = "298,32°K" },
                    new QuestionOption() { Explanation = "286,23°K" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas", IsCorrect = true },
                }
            },
            new Question()
            {
                Title = "Conversão de Fahrenheit para Kelvin",
                Description = "Qual é o valor de 103°F em Kelvin?",
                Difficulty = DifficultiesKind.Medium,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "321,322°K" },
                    new QuestionOption() { Explanation = "312,594°K", IsCorrect = true },
                    new QuestionOption() { Explanation = "301,234°K" },
                    new QuestionOption() { Explanation = "286,234°K" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Conversão de Fahrenheit para Celsius",
                Description = "Qual é o valor de 67°F em Celsius?",
                Difficulty = DifficultiesKind.Medium,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "19,4444...°C", IsCorrect = true },
                    new QuestionOption() { Explanation = "14,3333...°C" },
                    new QuestionOption() { Explanation = "17,326°C" },
                    new QuestionOption() { Explanation = "13,492°C" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            


            // Hard questions
            new Question()
            {
                Title = "Conversão de Celsius para Fahrenheit",
                Description = "Qual é o valor de 164°C em Fahrenheit?",
                Difficulty = DifficultiesKind.Hard,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "327,2°F", IsCorrect = true },
                    new QuestionOption() { Explanation = "303,4°F" },
                    new QuestionOption() { Explanation = "285,4°F" },
                    new QuestionOption() { Explanation = "246,2°F" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Conversão de Celsius para Fahrenheit",
                Description = "Qual é o valor de 253°C em Fahrenheit?",
                Difficulty = DifficultiesKind.Hard,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "365,2°F" },
                    new QuestionOption() { Explanation = "393,4°F" },
                    new QuestionOption() { Explanation = "435,6°F" },
                    new QuestionOption() { Explanation = "487,4°F", IsCorrect = true },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Conversão de Celsius para Fahrenheit",
                Description = "Qual é o valor de 275°C em Fahrenheit?",
                Difficulty = DifficultiesKind.Hard,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "582°F" },
                    new QuestionOption() { Explanation = "573°F" },
                    new QuestionOption() { Explanation = "542,3°F" },
                    new QuestionOption() { Explanation = "527°F", IsCorrect = true },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Conversão de Celsius para Kelvin",
                Description = "Qual é o valor de 153°C em Kelvin?",
                Difficulty = DifficultiesKind.Hard,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "426,15°K", IsCorrect = true },
                    new QuestionOption() { Explanation = "394,3°K" },
                    new QuestionOption() { Explanation = "342,2°K" },
                    new QuestionOption() { Explanation = "298,34°K" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Conversão de Celsius para Kelvin",
                Description = "Qual é o valor de 194°C em Kelvin?",
                Difficulty = DifficultiesKind.Hard,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "467,15°K", IsCorrect = true },
                    new QuestionOption() { Explanation = "401,3°K" },
                    new QuestionOption() { Explanation = "385,2°K" },
                    new QuestionOption() { Explanation = "345°K" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Conversão de Celsius para Kelvin",
                Description = "Qual é o valor de 231°C em Kelvin?",
                Difficulty = DifficultiesKind.Hard,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "564,23°K" },
                    new QuestionOption() { Explanation = "523,52°K" },
                    new QuestionOption() { Explanation = "504,15°K", IsCorrect = true },
                    new QuestionOption() { Explanation = "493°K" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Conversão de Fahrenheit para Kelvin",
                Description = "Qual é o valor de 231°F em Kelvin?",
                Difficulty = DifficultiesKind.Hard,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "383,706°K", IsCorrect = true },
                    new QuestionOption() { Explanation = "375,235°K" },
                    new QuestionOption() { Explanation = "342,394°K" },
                    new QuestionOption() { Explanation = "302,943°K" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Conversão de Fahrenheit para Kelvin",
                Description = "Qual é o valor de 185°F em Kelvin?",
                Difficulty = DifficultiesKind.Hard,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "358,15°K", IsCorrect = true },
                    new QuestionOption() { Explanation = "320,34°K" },
                    new QuestionOption() { Explanation = "301,23°K" },
                    new QuestionOption() { Explanation = "287,32°K" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Conversão de Fahrenheit para Kelvin",
                Description = "Qual é o valor de 123°F em Kelvin?",
                Difficulty = DifficultiesKind.Hard,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "323,746°K" },
                    new QuestionOption() { Explanation = "329,231°K" },
                    new QuestionOption() { Explanation = "352,132°K" },
                    new QuestionOption() { Explanation = "392,451°K" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas", IsCorrect = true },
                }
            },
            new Question()
            {
                Title = "Conversão de Fahrenheit para Celsius",
                Description = "Qual é o valor de 123°F em Celsius?",
                Difficulty = DifficultiesKind.Hard,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "50,5556°C", IsCorrect = true },
                    new QuestionOption() { Explanation = "46,232°C" },
                    new QuestionOption() { Explanation = "43,834°C" },
                    new QuestionOption() { Explanation = "41,923°C" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
        };
    }
}
