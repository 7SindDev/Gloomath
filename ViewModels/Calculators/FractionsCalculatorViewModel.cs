using Caliburn.Micro;
using Gloomath.Guards;
using Gloomath.Models;
using Gloomath.Models.FractionsCalculator;
using System;
using System.Collections.Generic;

namespace Gloomath.ViewModels.Calculators
{
	using FractionResult = Result<Fraction, Details>;
    using FractionResultCallback = Func<Fraction, Fraction, Result<Fraction, Details>>;

	public class FractionsCalculatorViewModel : Screen
    {
		private BindableCollection<char> _operators = new BindableCollection<char>() { '+', '-', '*', '/' };
		public BindableCollection<char> Operators
		{
			get
			{
				return _operators;
			}
			set
			{
                _operators = value;
				NotifyOfPropertyChange(() => Operators);
			}
		}

		private char _selectedOperator = '+';
		public char SelectedOperator
		{
			get
			{
				return _selectedOperator;
			}
			set
			{
                _selectedOperator = value;
				NotifyOfPropertyChange(() => SelectedOperator);
			}
		}

		private string _result = string.Empty;
        public string Result
        {
            get
            {
                return _result;
            }
            set
            {
                _result = value;
                NotifyOfPropertyChange(() => Result);
            }
        }

		private bool _isResultVisible = false;
		public bool IsResultVisible
		{
			get
			{
				return _isResultVisible;
			}
			set
			{
				_isResultVisible = value;
				NotifyOfPropertyChange(() => IsResultVisible);
			}
		}

		private Details _details = new Details();
		public Details Details
		{
			get
			{
				return _details;
			}
			set
			{
				_details = value;
				NotifyOfPropertyChange(() => Details);
			}
		}

		private Fraction _firstFraction = new Fraction();
		public Fraction FirstFraction
		{
			get
			{
				return _firstFraction;
			}
			set
			{
                _firstFraction = value;
				NotifyOfPropertyChange(() => FirstFraction);
			}
		}

		private Fraction _secondFraction = new Fraction();
		public Fraction SecondFraction
		{
			get
			{
				return _secondFraction;
			}
			set
			{
				_secondFraction = value;
				NotifyOfPropertyChange(() => SecondFraction);
			}
		}

		public void Calculate()
		{
			var operatorMethods = new Dictionary<char, FractionResultCallback>()
			{
				['+'] = new FractionResultCallback(Sum),
				['-'] = new FractionResultCallback(Subtract),
				['*'] = new FractionResultCallback(Multiply),
				['/'] = new FractionResultCallback(Divide)
			};

            Func<Fraction, Fraction, Result<Fraction, Details>> calculate = operatorMethods[SelectedOperator];
			FractionResult result = calculate(FirstFraction, SecondFraction);

			Result = FormatResult(result.Data.Numerator, result.Data.Denominator);

			Details.Explanation = result.Details.Explanation;
            Details.Expression = result.Details.Expression;
			NotifyOfPropertyChange(() => Details);

            IsResultVisible = true;
		}

		public FractionResult Sum(Fraction fraction1, Fraction fraction2)
		{
            Fraction fractionResult = new Fraction()
            {
                Numerator = (fraction1.Numerator * fraction2.Denominator) + (fraction2.Numerator * fraction1.Denominator),
                Denominator = fraction1.Denominator * fraction2.Denominator
            };

            return new FractionResult()
            {
                Data = fractionResult,
                Details = new Details()
				{
					Explanation = $"Pegando o numerador da primeira fração ({fraction1.Numerator}), multiplicamos pelo denominador da segunda fração ({fraction2.Denominator}), e o denominador da primeira fração ({fraction1.Denominator}) " +
								  $"multiplicamos pelo numerador da segunda fração ({fraction2.Numerator}), resultando na fração equivalente ao numerador sendo a soma da multiplicação de {fraction1.Numerator} e {fraction2.Denominator} que é igual a " +
								  $"{fractionResult.Numerator}, e o denominador sendo a multiplicação do denominador da primeira fração ({fraction1.Denominator}) com o denominador da segunda fração ({fraction2.Denominator}), que é igual a {fractionResult.Denominator}.",
					Expression = FormatExpression(fraction1, fraction2, fractionResult)
                }
            };
        }

		public FractionResult Subtract(Fraction fraction1, Fraction fraction2)
		{
			Fraction fractionResult = new Fraction()
			{
				Numerator = (fraction1.Numerator * fraction2.Denominator) - (fraction2.Numerator * fraction1.Denominator),
				Denominator = fraction1.Denominator * fraction2.Denominator
			};
		
            return new FractionResult()
			{
				Data = fractionResult,
				Details = new Details()
				{
					Explanation = $"Pegando o numerador da primeira fração ({fraction1.Numerator}), multiplicamos pelo denominador da segunda fração ({fraction2.Denominator}), e o denominador da primeira fração ({fraction1.Denominator}) " +
								  $"multiplicamos pelo numerador da segunda fração ({fraction2.Numerator}), resultando na fração equivalente ao numerador sendo a subtração da multiplicação de {fraction1.Numerator} e {fraction2.Denominator} que é igual a " +
								  $"{fractionResult.Numerator}, e o denominador sendo a multiplicação do denominador da primeira fração ({fraction1.Denominator}) com o denominador da segunda fração ({fraction2.Denominator}), que é igual a {fractionResult.Denominator}.",
                    Expression = FormatExpression(fraction1, fraction2, fractionResult)
                }
            };
        }

        public FractionResult Multiply(Fraction fraction1, Fraction fraction2)
        {
            Fraction fractionResult = new Fraction()
            {
                Numerator = fraction1.Numerator * fraction2.Numerator,
                Denominator = fraction1.Denominator * fraction2.Denominator
            };

            return new FractionResult()
			{
				Data = new Fraction()
				{
					Numerator = fraction1.Numerator * fraction2.Numerator,
					Denominator = fraction1.Denominator * fraction2.Denominator
				},
                Details = new Details()
				{
					Explanation = $"Pegando o numerador da primeira fração ({fraction1.Numerator}), multiplicamos pelo numerador da segunda fração ({fraction2.Numerator}), e o denominador da primeira fração ({fraction1.Denominator}) " +
								  $"multiplicamos pelo denominador da segunda fração ({fraction2.Denominator}), resultando na fração equivalente ao numerador sendo a multiplicação de {fraction1.Numerator} e {fraction2.Numerator} que é igual a " +
							      $"{fractionResult.Numerator}, e o denominador sendo a multiplicação do denominador da primeira fração ({fraction1.Denominator}) com o denominador da segunda fração ({fraction2.Denominator}), que é igual a {fractionResult.Denominator}.",
					Expression = FormatExpression(fraction1, fraction2, fractionResult)
                }
			};
		}
		public FractionResult Divide(Fraction fraction1, Fraction fraction2)
		{
            Fraction fractionResult = new Fraction()
            {
                Numerator = (fraction1.Numerator * fraction2.Denominator),
                Denominator = fraction1.Denominator * fraction2.Denominator
            };

            return new FractionResult()
			{
				Data = new Fraction()
                {
                    Numerator = fraction1.Numerator * fraction2.Denominator,
                    Denominator = fraction1.Denominator * fraction2.Numerator
                },
				Details = new Details()
				{
					Explanation = $"Antes de calcular, pegamos a segunda fração, invertemos ela, ficando de {fraction2.Numerator}/{fraction2.Denominator} para {fraction2.Denominator}/{fraction2.Numerator}, podendo depois multiplicar as frações normalmente.",
                    Expression = FormatExpression(fraction1, fraction2, fractionResult)
                }
            };
        }

		private string FormatResult(double numerator, double denominator)
		{
			return @$"\frac{{{numerator}}}{{{denominator}}}";
		}

		private string FormatExpression(Fraction fraction1, Fraction fraction2, Fraction fractionResult)
		{
			return $"{FormatResult(fraction1.Numerator, fraction1.Denominator)} {SelectedOperator} {FormatResult(fraction2.Numerator, fraction2.Denominator)} = {FormatResult(fractionResult.Numerator, fractionResult.Denominator)}";
        }
    }
}