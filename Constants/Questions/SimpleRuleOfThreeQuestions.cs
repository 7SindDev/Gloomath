using Gloomath.Models;
using System.Collections.Generic;

namespace Gloomath.Constants.Questions
{
    public static class SimpleRuleOfThreeQuestions
    {
        public static List<Question> Questions = new List<Question>()
        {
            // Easy questions
            new Question()
            {
                Title = "Regra de três",
                Description = "Uma senhora comprou 5 pães de sal, custando R$0,50 centavos cada um e gastando R$2,50 no total. No dia seguinte, os mesmos tipos de pães que ela comprou ficaram em promoção, passando a custar R$0,25. Se ela comprasse esses pães no dia da promoção, quanto ela gastaria no total?",
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "R$1,75" },
                    new QuestionOption() { Explanation = "R$1,50" },
                    new QuestionOption() { Explanation = "R$1,25" },
                    new QuestionOption() { Explanation = "R$1,00", IsCorrect = true },
                    new QuestionOption() { Explanation = "R$0,75" },
                }
            },
            new Question()
            {
                Title = "Regra de três",
                Description = "Paulo usou 20 blocos de Lego para fazer uma casinha, mas ele precisava fazer mais 9 para completar sua cidade de Lego. Se com 20 blocos de Lego ele conseguiu fazer uma casinha, ele vai precisar de quantos blocos para fazer as outras 9 casas?",
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "200" },
                    new QuestionOption() { Explanation = "180", IsCorrect = true },
                    new QuestionOption() { Explanation = "160" },
                    new QuestionOption() { Explanation = "140" },
                    new QuestionOption() { Explanation = "120" },
                }
            },
            new Question()
            {
                Title = "Regra de três",
                Description = "Maria e Pedro tinha R$2,50 reais e, juntando eles, compraram um salgado por R$5,00. Se eles tivessem R$10,00, eles conseguiriam comprar quantos salgados?",
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "5" },
                    new QuestionOption() { Explanation = "4", IsCorrect = true },
                    new QuestionOption() { Explanation = "3" },
                    new QuestionOption() { Explanation = "2" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Regra de três",
                Description = "Jorge conseguia levantar 5 tábuas de madeira, que pesava no total 25kg. Se ele levantasse o dobro da quantidade de madeiras, qual seria o peso total?",
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "100kg" },
                    new QuestionOption() { Explanation = "75kg" },
                    new QuestionOption() { Explanation = "50kg", IsCorrect = true },
                    new QuestionOption() { Explanation = "25kg" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Regra de três",
                Description = "Joana, com R$50,00 reais, comprou 250 balas para o Halloween. Se ele tivesse o triplo do seu dinheiro, quantas balas ele conseguiria comprar?",
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "1250" },
                    new QuestionOption() { Explanation = "1000" },
                    new QuestionOption() { Explanation = "750", IsCorrect = true },
                    new QuestionOption() { Explanation = "500" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Regra de três",
                Description = "Carlos, com R$25,00 reais, comprou 25 lápis para os seus amigos. Se ele tivesse o quádruplo do seu dinheiro, quantos lápis ele conseguiria comprar?",
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "R$150,00" },
                    new QuestionOption() { Explanation = "R$125,00" },
                    new QuestionOption() { Explanation = "R$100,00", IsCorrect = true },
                    new QuestionOption() { Explanation = "R$75,00" },
                    new QuestionOption() { Explanation = "R$50,00" },
                }
            },
            new Question()
            {
                Title = "Regra de três",
                Description = "Enzo, o professor de educação física, passou uma atividade prática para os seus 10 alunos darem voltas na quadra sem parar, dando 5 balas para cada um a cada volta. Se todos os alunos dessem 7 voltas, quantas balas cada um ganharia?",
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "50" },
                    new QuestionOption() { Explanation = "45" },
                    new QuestionOption() { Explanation = "40" },
                    new QuestionOption() { Explanation = "35", IsCorrect = true },
                    new QuestionOption() { Explanation = "30" },
                }
            },
            new Question()
            {
                Title = "Regra de três",
                Description = "Num supermercado, acidentalmente, um senhor bateu numa estante com 5 copos de vidro e os 5 foram quebrados. Se o senhor batesse em mais 3 estantes, quantos copos ele quebraria no total?",
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "20", IsCorrect = true },
                    new QuestionOption() { Explanation = "15" },
                    new QuestionOption() { Explanation = "10" },
                    new QuestionOption() { Explanation = "5" },
                    new QuestionOption() { Explanation = "Nenhum, pois os outros copos eram de plástico." },
                }
            },
            new Question()
            {
                Title = "Regra de três",
                Description = "Havia balas que José queria comprar num supermercado, e como ele tinha R$10,00, ele comprou 10 balas, que custavam R$0,50 reais cada uma. Todavia, a mãe de José mandou ele gastar apenas uma parte do dinheiro, sendo assim, se não fosse por essa exceção, se José usasse todo o seu dinheiro, quantas balas ele obteria?",
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "20" },
                    new QuestionOption() { Explanation = "15" },
                    new QuestionOption() { Explanation = "10", IsCorrect = true },
                    new QuestionOption() { Explanation = "5" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas." },
                }
            },
            new Question()
            {
                Title = "Regra de três",
                Description = "Sabendo que com R$5,00 daria para comprar 5 canetas, quantas canetas seria possível comprar se o dinheiro fosse igual ao quíntuplo de 5?",
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "35" },
                    new QuestionOption() { Explanation = "30" },
                    new QuestionOption() { Explanation = "25", IsCorrect = true },
                    new QuestionOption() { Explanation = "20" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas." },
                }
            },



            // Medium questions
            new Question()
            {
                Title = "Regra de três",
                Description = "Sabendo que com R$25,00 daria para comprar 5 salgados, quantos salgados seria possível comprar se o dinheiro fosse igual ao quíntuplo de R$25,00?",
                Difficulty = DifficultiesKind.Medium,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "35" },
                    new QuestionOption() { Explanation = "30" },
                    new QuestionOption() { Explanation = "25", IsCorrect = true },
                    new QuestionOption() { Explanation = "20" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas." },
                }
            },
            new Question()
            {
                Title = "Regra de três",
                Description = "Sabendo que com R$150,00 daria para comprar 10 melancia, quantas melancias seriam possíveis comprar se o dinheiro fosse igual ao triplo de R$150,00?",
                Difficulty = DifficultiesKind.Medium,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "35" },
                    new QuestionOption() { Explanation = "30", IsCorrect = true },
                    new QuestionOption() { Explanation = "25" },
                    new QuestionOption() { Explanation = "20" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas." },
                }
            },
            new Question()
            {
                Title = "Regra de três",
                Description = "Sabendo que com R$100,00 daria para comprar 25 salgados, quantos salgados seriam possíveis comprar se o dinheiro fosse igual ao quíntuplo de R$100,00?",
                Difficulty = DifficultiesKind.Medium,
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
                Title = "Regra de três",
                Description = "15 blocos são equivalentes a 3 toneladas, assim como 90 blocos são equivalentes a:",
                Difficulty = DifficultiesKind.Medium,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "38 toneladas" },
                    new QuestionOption() { Explanation = "28 toneladas" },
                    new QuestionOption() { Explanation = "18 toneladas", IsCorrect = true },
                    new QuestionOption() { Explanation = "8 toneladas" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Regra de três",
                Description = "15 sacos de arroz são equivalentes a 30 quilos, assim como 45 sacos de arroz são equivalentes a:",
                Difficulty = DifficultiesKind.Medium,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "90 quilos", IsCorrect = true },
                    new QuestionOption() { Explanation = "80 quilos" },
                    new QuestionOption() { Explanation = "70 quilos" },
                    new QuestionOption() { Explanation = "60 quilos" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Regra de três",
                Description = "8 sacos de feijão são equivalentes a 2.5 quilos, assim como 16 sacos de feijão são equivalentes a:",
                Difficulty = DifficultiesKind.Medium,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "5 quilos", IsCorrect = true },
                    new QuestionOption() { Explanation = "5.5 quilos" },
                    new QuestionOption() { Explanation = "6 quilos" },
                    new QuestionOption() { Explanation = "6.5 quilos" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Regra de três",
                Description = "13 peixes médios são equivalentes a 25 quilos, assim como 40 peixes médios são equivalentes a:",
                Difficulty = DifficultiesKind.Medium,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "73,34 quilos" },
                    new QuestionOption() { Explanation = "75,42 quilos" },
                    new QuestionOption() { Explanation = "74,94 quilos" },
                    new QuestionOption() { Explanation = "76,23 quilos" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas", IsCorrect = true },
                }
            },
            new Question()
            {
                Title = "Regra de três",
                Description = "13 tijolos são equivalentes a 36 quilos, assim como 39 tijolos são equivalentes a:",
                Difficulty = DifficultiesKind.Medium,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "128 quilos" },
                    new QuestionOption() { Explanation = "118 quilos" },
                    new QuestionOption() { Explanation = "110 quilos" },
                    new QuestionOption() { Explanation = "108 quilos", IsCorrect = true },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Regra de três",
                Description = "50 pedras pequenas são equivalentes a 5 quilos, assim como 300 pedras são equivalentes a:",
                Difficulty = DifficultiesKind.Medium,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "30 quilos", IsCorrect = true },
                    new QuestionOption() { Explanation = "20 quilos" },
                    new QuestionOption() { Explanation = "10 quilos" },
                    new QuestionOption() { Explanation = "40 quilos" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Regra de três",
                Description = "10 caixas são equivalentes a 500g, assim como 310 caixas são equivalentes a:",
                Difficulty = DifficultiesKind.Medium,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "15500g", IsCorrect = true },
                    new QuestionOption() { Explanation = "13500g" },
                    new QuestionOption() { Explanation = "13000g" },
                    new QuestionOption() { Explanation = "12500g" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            


            // Hard questions
            new Question()
            {
                Title = "Regra de três",
                Description = "300 blocos são equivalentes a 900kg, assim como 900 blocos são equivalentes a:",
                Difficulty = DifficultiesKind.Hard,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "3.100" },
                    new QuestionOption() { Explanation = "2.700", IsCorrect = true },
                    new QuestionOption() { Explanation = "2.300" },
                    new QuestionOption() { Explanation = "1.900" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Regra de três",
                Description = "500 bolinhas são equivalentes a 34,5kg, assim como 3.452 blocos são equivalentes a:",
                Difficulty = DifficultiesKind.Hard,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "238,19kg", IsCorrect = true },
                    new QuestionOption() { Explanation = "236,34kg" },
                    new QuestionOption() { Explanation = "235,93kg" },
                    new QuestionOption() { Explanation = "232,12kg" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Regra de três",
                Description = "753 bolinhas são equivalentes a 34,5kg, assim como 2.341 blocos são equivalentes a:",
                Difficulty = DifficultiesKind.Hard,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "105,25kg" },
                    new QuestionOption() { Explanation = "107,65kg" },
                    new QuestionOption() { Explanation = "110,33kg" },
                    new QuestionOption() { Explanation = "113,12kg" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas", IsCorrect = true },
                }
            },
            new Question()
            {
                Title = "Regra de três",
                Description = "150 copos de plástico são equivalentes a 2kg, assim como 1.324 blocos são equivalentes a:",
                Difficulty = DifficultiesKind.Hard,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "17,63g" },
                    new QuestionOption() { Explanation = "16,23kg" },
                    new QuestionOption() { Explanation = "15,33kg" },
                    new QuestionOption() { Explanation = "13,12kg" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas", IsCorrect = true },
                }
            },
            new Question()
            {
                Title = "Regra de três",
                Description = "3.452 bolinhas são equivalentes a 5kg, assim como 16.324 blocos são equivalentes a:",
                Difficulty = DifficultiesKind.Hard,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "13,45kg" },
                    new QuestionOption() { Explanation = "16,23kg" },
                    new QuestionOption() { Explanation = "19,29kg" },
                    new QuestionOption() { Explanation = "23,64kg", IsCorrect = true },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Regra de três",
                Description = "5 cadernos são equivalentes a 1kg, assim como 328 cadernos são equivalentes a:",
                Difficulty = DifficultiesKind.Hard,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "65,45kg" },
                    new QuestionOption() { Explanation = "65,60kg", IsCorrect = true },
                    new QuestionOption() { Explanation = "65,73kg" },
                    new QuestionOption() { Explanation = "65,94kg" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Regra de três",
                Description = "3 monitores são equivalentes a 18kg, assim como 34 monitores são equivalentes a:",
                Difficulty = DifficultiesKind.Hard,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "195kg" },
                    new QuestionOption() { Explanation = "204kg", IsCorrect = true },
                    new QuestionOption() { Explanation = "230kg" },
                    new QuestionOption() { Explanation = "254kg" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Regra de três",
                Description = "3 monitores são equivalentes a 18kg, assim como 34 monitores são equivalentes a:",
                Difficulty = DifficultiesKind.Hard,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "195kg" },
                    new QuestionOption() { Explanation = "204kg", IsCorrect = true },
                    new QuestionOption() { Explanation = "230kg" },
                    new QuestionOption() { Explanation = "254kg" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Regra de três",
                Description = "10 teclados são equivalentes a 8kg, assim como 65 teclados são equivalentes a:",
                Difficulty = DifficultiesKind.Hard,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "52kg", IsCorrect = true },
                    new QuestionOption() { Explanation = "34kg" },
                    new QuestionOption() { Explanation = "24kg" },
                    new QuestionOption() { Explanation = "16kg" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
            new Question()
            {
                Title = "Regra de três",
                Description = "10 teclados são equivalentes a 8kg, assim como 65 teclados são equivalentes a:",
                Difficulty = DifficultiesKind.Hard,
                Options = new List<QuestionOption>()
                {
                    new QuestionOption() { Explanation = "52kg", IsCorrect = true },
                    new QuestionOption() { Explanation = "34kg" },
                    new QuestionOption() { Explanation = "24kg" },
                    new QuestionOption() { Explanation = "16kg" },
                    new QuestionOption() { Explanation = "Nenhuma das alternativas" },
                }
            },
        };
    }
}
