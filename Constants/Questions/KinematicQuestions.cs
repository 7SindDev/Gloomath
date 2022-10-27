using Gloomath.Models;
using System.Collections.Generic;

namespace Gloomath.Constants.Questions
{
    public class KinematicQuestions
    {
        public static List<Question> Questions = new List<Question>()
        {
            // Easy questions
            new Question()
            {
                Title = "Variação do deslocamento",
                Description = "Sabendo que o tempo que um carro chegou no Sf (deslocamento final) foi de 10 segundos a 15m/s, qual é a variação do deslocamento?",
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "200m" },
                    new QuestionOption() { Explanation = "150m", IsCorrect = true },
                    new QuestionOption() { Explanation = "100m" },
                    new QuestionOption() { Explanation = "50m" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Variação do deslocamento",
                Description = "Sabendo que o tempo que um carro chegou no Sf (deslocamento final) foi de 20 segundos a 45m/s, qual é a variação do deslocamento?",
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "1100m" },
                    new QuestionOption() { Explanation = "1000m" },
                    new QuestionOption() { Explanation = "900m", IsCorrect = true },
                    new QuestionOption() { Explanation = "800m" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Variação do deslocamento",
                Description = "Sabendo que o tempo que um carro chegou no Sf (deslocamento final) foi de 30 segundos a 20m/s, qual é a variação do deslocamento?",
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "1100m" },
                    new QuestionOption() { Explanation = "900m" },
                    new QuestionOption() { Explanation = "600m", IsCorrect = true },
                    new QuestionOption() { Explanation = "300m" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Variação do tempo",
                Description = "Sabendo que o carro percorreu 300m a 20m/s, qual é a variação do tempo?",
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "19s" },
                    new QuestionOption() { Explanation = "17s" },
                    new QuestionOption() { Explanation = "15s", IsCorrect = true },
                    new QuestionOption() { Explanation = "13s" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Variação do tempo",
                Description = "Sabendo que o carro percorreu 450 a 50m/s, qual é a variação do tempo?",
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "9s", IsCorrect = true },
                    new QuestionOption() { Explanation = "11s" },
                    new QuestionOption() { Explanation = "13s" },
                    new QuestionOption() { Explanation = "15s" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Variação do tempo",
                Description = "Sabendo que o carro percorreu 600 a 20m/s, qual é a variação do tempo?",
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "30s", IsCorrect = true },
                    new QuestionOption() { Explanation = "33s" },
                    new QuestionOption() { Explanation = "36s" },
                    new QuestionOption() { Explanation = "39s" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Velocidade média",
                Description = "Sabendo que o carro percorreu 400m em 15s, qual é a velocidade média?",
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "aprox. 26,67m/s", IsCorrect = true },
                    new QuestionOption() { Explanation = "aprox. 25,67m/s" },
                    new QuestionOption() { Explanation = "aprox. 24,67m/s" },
                    new QuestionOption() { Explanation = "aprox. 23,67m/s" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Velocidade média",
                Description = "Sabendo que o carro percorreu 250m em 5s, qual é a velocidade média?",
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "90m/s" },
                    new QuestionOption() { Explanation = "70m/s" },
                    new QuestionOption() { Explanation = "50m/s", IsCorrect = true },
                    new QuestionOption() { Explanation = "30m/s" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Velocidade média",
                Description = "Sabendo que o carro percorreu 560m em 25s, qual é a velocidade média?",
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "18,40m/s", IsCorrect = true },
                    new QuestionOption() { Explanation = "19,30m/s" },
                    new QuestionOption() { Explanation = "20,20m/s" },
                    new QuestionOption() { Explanation = "21,10m/s" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Velocidade média",
                Description = "Sabendo que o carro percorreu 270m em 10s, qual é a velocidade média?",
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "30m/s" },
                    new QuestionOption() { Explanation = "29m/s" },
                    new QuestionOption() { Explanation = "28m/s" },
                    new QuestionOption() { Explanation = "27m/s", IsCorrect = true },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },



            // Medium questions
            new Question()
            {
                Title = "Variação do deslocamento",
                Description = "Sabendo que o tempo que um carro chegou no Sf (deslocamento final) foi de 60 segundos a 5m/s, qual é a variação do deslocamento?",
                Difficulty = DifficultiesKind.Medium,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "450m" },
                    new QuestionOption() { Explanation = "400m" },
                    new QuestionOption() { Explanation = "350m" },
                    new QuestionOption() { Explanation = "300m", IsCorrect = true },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Variação do deslocamento",
                Description = "Sabendo que o tempo que um carro chegou no Sf (deslocamento final) foi de 120 segundos a 2,5m/s, qual é a variação do deslocamento?",
                Difficulty = DifficultiesKind.Medium,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "450m" },
                    new QuestionOption() { Explanation = "400m" },
                    new QuestionOption() { Explanation = "350m" },
                    new QuestionOption() { Explanation = "300m", IsCorrect = true },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Variação do deslocamento",
                Description = "Sabendo que o tempo que um carro chegou no Sf (deslocamento final) foi de 120 segundos a 45m/s, qual é a variação do deslocamento?",
                Difficulty = DifficultiesKind.Medium,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "5900m" },
                    new QuestionOption() { Explanation = "5700m" },
                    new QuestionOption() { Explanation = "5400m", IsCorrect = true },
                    new QuestionOption() { Explanation = "5100m" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Variação do tempo",
                Description = "Sabendo que o carro percorreu 1200 a 300m/s, qual é a variação do tempo?",
                Difficulty = DifficultiesKind.Medium,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "6s" },
                    new QuestionOption() { Explanation = "5s" },
                    new QuestionOption() { Explanation = "4s", IsCorrect = true },
                    new QuestionOption() { Explanation = "3s" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Variação do tempo",
                Description = "Sabendo que o carro percorreu 1600 a 500m/s, qual é a variação do tempo?",
                Difficulty = DifficultiesKind.Medium,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "4s" },
                    new QuestionOption() { Explanation = "3,80s" },
                    new QuestionOption() { Explanation = "3,60s" },
                    new QuestionOption() { Explanation = "3,40s" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas", IsCorrect = true },
                }
            },
            new Question()
            {
                Title = "Variação do tempo",
                Description = "Sabendo que o carro percorreu 930 a 60m/s, qual é a variação do tempo?",
                Difficulty = DifficultiesKind.Medium,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "16s" },
                    new QuestionOption() { Explanation = "15,50s", IsCorrect = true },
                    new QuestionOption() { Explanation = "15s" },
                    new QuestionOption() { Explanation = "14,50s" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Velocidade média",
                Description = "Sabendo que o carro percorreu 5000m em 30s, qual é a velocidade média?",
                Difficulty = DifficultiesKind.Medium,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "aprox. 175,22m/s" },
                    new QuestionOption() { Explanation = "aprox. 174,32m/s" },
                    new QuestionOption() { Explanation = "aprox. 172,62m/s" },
                    new QuestionOption() { Explanation = "aprox. 170,12m/s" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas", IsCorrect = true },
                }
            },
            new Question()
            {
                Title = "Velocidade média",
                Description = "Sabendo que o carro percorreu 2400m em 30s, qual é a velocidade média?",
                Difficulty = DifficultiesKind.Medium,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "80m/s", IsCorrect = true },
                    new QuestionOption() { Explanation = "90m/s" },
                    new QuestionOption() { Explanation = "100m/s" },
                    new QuestionOption() { Explanation = "110m/s" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Velocidade média",
                Description = "Sabendo que o carro percorreu 1700m em 50s, qual é a velocidade média?",
                Difficulty = DifficultiesKind.Medium,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "34m/s", IsCorrect = true },
                    new QuestionOption() { Explanation = "32m/s" },
                    new QuestionOption() { Explanation = "30m/s" },
                    new QuestionOption() { Explanation = "28m/s" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Velocidade média",
                Description = "Sabendo que o carro percorreu 1100m em 50s, qual é a velocidade média?",
                Difficulty = DifficultiesKind.Medium,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "26m/s" },
                    new QuestionOption() { Explanation = "24m/s" },
                    new QuestionOption() { Explanation = "22m/s", IsCorrect = true },
                    new QuestionOption() { Explanation = "20m/s" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            


            // Hard questions
            new Question()
            {
                Title = "Variação do deslocamento",
                Description = "Sabendo que o tempo que um carro chegou no Sf (deslocamento final) foi de 180 segundos a 100m/s, qual é a variação do deslocamento?",
                Difficulty = DifficultiesKind.Hard,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "21.000m" },
                    new QuestionOption() { Explanation = "20.000m" },
                    new QuestionOption() { Explanation = "19.000m" },
                    new QuestionOption() { Explanation = "18.000m", IsCorrect = true },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Variação do deslocamento",
                Description = "Sabendo que o tempo que um carro chegou no Sf (deslocamento final) foi de 150 segundos a 110m/s, qual é a variação do deslocamento?",
                Difficulty = DifficultiesKind.Hard,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "16.500m", IsCorrect = true },
                    new QuestionOption() { Explanation = "17.000m" },
                    new QuestionOption() { Explanation = "17.500m" },
                    new QuestionOption() { Explanation = "18.000m" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Variação do deslocamento",
                Description = "Sabendo que o tempo que um carro chegou no Sf (deslocamento final) foi de 173 segundos a 64m/s, qual é a variação do deslocamento?",
                Difficulty = DifficultiesKind.Hard,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "11.077m" },
                    new QuestionOption() { Explanation = "11.075m" },
                    new QuestionOption() { Explanation = "11.073m" },
                    new QuestionOption() { Explanation = "11.071m" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas", IsCorrect = true },
                }
            },
            new Question()
            {
                Title = "Variação do tempo",
                Description = "Sabendo que o carro percorreu 930 a 60m/s, qual é a variação do tempo?",
                Difficulty = DifficultiesKind.Hard,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "aprox. 17,40s" },
                    new QuestionOption() { Explanation = "aprox. 17,30s" },
                    new QuestionOption() { Explanation = "aprox. 17,20s" },
                    new QuestionOption() { Explanation = "aprox. 17,10s" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas", IsCorrect = true },
                }
            },
            new Question()
            {
                Title = "Variação do tempo",
                Description = "Sabendo que o carro percorreu 852 a 60m/s, qual é a variação do tempo?",
                Difficulty = DifficultiesKind.Hard,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "14,60s" },
                    new QuestionOption() { Explanation = "14,40s" },
                    new QuestionOption() { Explanation = "14,20s", IsCorrect = true },
                    new QuestionOption() { Explanation = "14,00s" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Variação do tempo",
                Description = "Sabendo que o carro percorreu 750 a 30m/s, qual é a variação do tempo?",
                Difficulty = DifficultiesKind.Hard,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "25,00s", IsCorrect = true },
                    new QuestionOption() { Explanation = "25,20s" },
                    new QuestionOption() { Explanation = "25,40s" },
                    new QuestionOption() { Explanation = "25,50s" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Variação do tempo",
                Description = "Sabendo que o carro percorreu 750 a 30m/s, qual é a variação do tempo?",
                Difficulty = DifficultiesKind.Hard,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "25,00s", IsCorrect = true },
                    new QuestionOption() { Explanation = "25,20s" },
                    new QuestionOption() { Explanation = "25,40s" },
                    new QuestionOption() { Explanation = "25,50s" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Velocidade média",
                Description = "Sabendo que o carro percorreu 130m em 180s, qual é a velocidade média?",
                Difficulty = DifficultiesKind.Hard,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "0,72m/s", IsCorrect = true },
                    new QuestionOption() { Explanation = "0,74m/s" },
                    new QuestionOption() { Explanation = "0,75m/s" },
                    new QuestionOption() { Explanation = "0,76m/s" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Velocidade média",
                Description = "Sabendo que o carro percorreu 700 em 360s, qual é a velocidade média?",
                Difficulty = DifficultiesKind.Hard,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "1,52m/s" },
                    new QuestionOption() { Explanation = "0,64m/s" },
                    new QuestionOption() { Explanation = "0,75m/s" },
                    new QuestionOption() { Explanation = "0,94m/s", IsCorrect = true },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Velocidade média",
                Description = "Sabendo que o carro percorreu 80.324m em 30s, qual é a velocidade média?",
                Difficulty = DifficultiesKind.Hard,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "2677,47m/s", IsCorrect = true },
                    new QuestionOption() { Explanation = "2571,37m/s" },
                    new QuestionOption() { Explanation = "2427,72m/s" },
                    new QuestionOption() { Explanation = "2347,15m/s" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
        };
    }
}
