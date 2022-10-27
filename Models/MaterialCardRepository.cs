using Caliburn.Micro;
using Gloomath.Constants.Questions;
using Gloomath.ViewModels.Calculators;
using Gloomath.ViewModels.Practices;
using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;

namespace Gloomath.Models
{
    public class MaterialCardRepository
    {
        private BindableCollection<MaterialCard> _materialCards = new BindableCollection<MaterialCard>()
        {
            new MaterialCard()
            {
                Title = "Matemática",
                Description = "Ciência do raciocínio lógico e abstrato, que estuda quantidades, espaço e medidas, estruturas, variações e estatística. Não há, porém, uma definição consensual por parte da comunidade científica.",
                Icon = PackIconKind.Abacus,
                Contents = new List<Content>()
                {
                    new Content()
                    {
                        Icon = PackIconKind.ContrastBox,
                        Label = "Operações Aritméticas",
                        Section = new Section()
                        {
                            CalculatorViewModel = new ArithmeticOperationsCalculatorViewModel(),
                            PracticeTopic = new PracticeTopic()
                            {
                                Questions = ArithmeticOperationsQuestions.Questions
                            }
                        }
                    },
                    new Content()
                    {
                        Icon = PackIconKind.SlashForward,
                        Label = "Operações com frações",
                        Section = new Section()
                        {
                            CalculatorViewModel = new FractionsCalculatorViewModel(),
                            PracticeTopic = new PracticeTopic()
                            {
                                Questions = FractionOperationsQuestions.Questions
                            }
                        }
                    },
                    new Content()
                    {
                        Icon = PackIconKind.FormatSuperscript,
                        Label = "Potencialização e radiciação",
                        Section = new Section()
                        {
                            CalculatorViewModel = new PotencyAndRootingCalculatorViewModel(),
                            PracticeTopic = new PracticeTopic()
                            {
                                Questions = PotencyAndRootingQuestions.Questions
                            }
                        }
                    },
                    new Content()
                    {
                        Icon = PackIconKind.Numeric6BoxOutline,
                        Label = "Número Primo",
                        Section = new Section()
                        {
                            CalculatorViewModel = new PrimeCalculatorViewModel(),
                            PracticeTopic = new PracticeTopic()
                            {
                                Questions = IsPrimeQuestions.Questions
                            }
                        }
                    },
                    new Content()
                    {
                        Icon = PackIconKind.FractionOneHalf,
                        Label = "Fatoração",
                        Section = new Section()
                        {
                            CalculatorViewModel = new FactorizationCalculatorViewModel(),
                            PracticeTopic = new PracticeTopic()
                            {
                                Questions = FactorizationQuestions.Questions
                            }
                        }
                    },
                    new Content()
                    {
                        Icon = PackIconKind.AlphaMBoxOutline,
                        Label = "MMC & MDC",
                        Section = new Section()
                        {
                            CalculatorViewModel = new MMCAndMDCCalculatorViewModel(),
                            PracticeTopic = new PracticeTopic()
                            {
                                Questions = MMCAndMDCQuestions.Questions
                            }
                        }
                    },
                    new Content()
                    {
                        Icon = PackIconKind.PercentCircleOutline,
                        Label = "Porcentagem",
                        Section = new Section()
                        {
                            CalculatorViewModel = new PercentageCalculatorViewModel(),
                            PracticeTopic = new PracticeTopic()
                            {
                                Questions = PercentageQuestions.Questions
                            }
                        }
                    },
                    new Content()
                    {
                        Icon = PackIconKind.ChartBoxPlusOutline,
                        Label = "Média Aritmética",
                        Section = new Section()
                        {
                            CalculatorViewModel = new ArithmeticAverageCalculatorViewModel(),
                            PracticeTopic = new PracticeTopic()
                            {
                                Questions = ArithmeticAverageQuestions.Questions
                            }
                        }
                    },
                    new Content()
                    {
                        Icon = PackIconKind.FractionOneHalf,
                        Label = "Regra de Três Simples",
                        Section = new Section()
                        {
                            CalculatorViewModel = new SimpleRuleOfThreeCalculatorViewModel(),
                            PracticeTopic = new PracticeTopic()
                            {
                                Questions = SimpleRuleOfThreeQuestions.Questions
                            }
                        }
                    },
                }
            },
            new MaterialCard()
            {
                Title = "Física",
                Description = "Ciência que estuda a natureza e seus fenômenos em seus aspectos gerais. Analisa suas relações e propriedades, além de descrever e explicar a maior parte de suas consequências.",
                Icon = PackIconKind.Atom,
                Contents = new List<Content>()
                {
                    new Content() {
                        Icon = PackIconKind.CarOutline,
                        Label = "Cinemática",
                        Section = new Section()
                        {
                            CalculatorViewModel = new KinematicCalculatorViewModel(),
                            PracticeTopic = new PracticeTopic()
                            {
                                Questions = KinematicQuestions.Questions
                            }
                        }
                    },
                    new Content() {
                        Icon = PackIconKind.Temperature,
                        Label = "Termodinâmica",
                        Section = new Section()
                        {
                            CalculatorViewModel = new ThermodynamicCalculatorViewModel(),
                            PracticeTopic = new PracticeTopic()
                            {
                                Questions = ThermodynamicQuestions.Questions
                            }
                        }
                    }
                }
            },
        };

        public int Count => _materialCards.Count;
        public MaterialCard this[int index] => _materialCards[index];
    }
}