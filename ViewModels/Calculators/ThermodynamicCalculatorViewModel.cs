using Caliburn.Micro;
using Gloomath.Models;
using Gloomath.Models.ThermodynamicCalculator;
using System;
using System.Collections.Generic;

// celsius = 0
// fahrenheit = 1
// kelvin = 2

public enum TemperatureScalesPattern {
    CelsiusToFahrenheit = TemperatureScalesKind.Celsius + TemperatureScalesKind.Fahrenheit,
    CelsiusToKelvin = TemperatureScalesKind.Celsius + TemperatureScalesKind.Kelvin,
    FahrenheitToKelvin = TemperatureScalesKind.Fahrenheit + TemperatureScalesKind.Kelvin
}

namespace Gloomath.ViewModels.Calculators
{
    using ThermodynamicResult = Result<double, FormuledDetails>;
    using ThermodynamicResultCallback = Func<Result<double, FormuledDetails>>;

    public class ThermodynamicCalculatorViewModel : Screen
    {

        private Temperature _firstTemperature = new Temperature();
        public Temperature FirstTemperature
        {
            get
            {
                return _firstTemperature;
            }
            set
            {
                _firstTemperature = value;
                NotifyOfPropertyChange(() => FirstTemperature);
            }
        }

        private Temperature _secondTemperature = new Temperature();
        public Temperature SecondTemperature
        {
            get
            {
                return _secondTemperature;
            }
            set
            {
                _secondTemperature = value;
                NotifyOfPropertyChange(() => SecondTemperature);
            }
        }

        private BindableCollection<string> _tempereatureScales = new BindableCollection<string>(Enum.GetNames<TemperatureScalesKind>());
        public BindableCollection<string> TemperatureScales
        {
            get
            {
                return _tempereatureScales;
            }
            set
            {
                _tempereatureScales = value;
                NotifyOfPropertyChange(() => TemperatureScales);
            }
        }

        private TemperatureScalesKind _selectedFirstTemperatureScale = TemperatureScalesKind.Celsius;
        public TemperatureScalesKind SelectedFirstTemperatureScale
        {
            get
            {
                return _selectedFirstTemperatureScale;
            }
            set
            {
                // Prevent the two scales from being the same kind
                if (value == SelectedSecondTemperatureScale)
                {
                    _selectedSecondTemperatureScale = _selectedFirstTemperatureScale;
                }


                _selectedFirstTemperatureScale = value;
                NotifyOfPropertyChange(() => SelectedFirstTemperatureScale);
                NotifyOfPropertyChange(() => SelectedSecondTemperatureScale);
            }
        }

        private TemperatureScalesKind _selectedSecondTemperatureScale = TemperatureScalesKind.Fahrenheit;
        public TemperatureScalesKind SelectedSecondTemperatureScale
        {
            get
            {
                return _selectedSecondTemperatureScale;
            }
            set
            {
                // Prevent the two scales from being the same kind
                if (value == SelectedFirstTemperatureScale)
                {
                    _selectedFirstTemperatureScale = _selectedSecondTemperatureScale;
                }


                _selectedSecondTemperatureScale = value;
                NotifyOfPropertyChange(() => SelectedSecondTemperatureScale);
                NotifyOfPropertyChange(() => SelectedFirstTemperatureScale);
            }
        }

        private FormuledDetails _details = new FormuledDetails();
        public FormuledDetails Details
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

        private string _result = "";
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

        public void Calculate()
        {
            Dictionary<int, ThermodynamicResultCallback> calculateMethods = new Dictionary<int, ThermodynamicResultCallback>()
            {
                [(int)TemperatureScalesPattern.CelsiusToFahrenheit] = ConvertCelsiusToFahrenheit,
                [(int)TemperatureScalesPattern.CelsiusToKelvin] = ConvertCelsiusToKelvin,
                [(int)TemperatureScalesPattern.FahrenheitToKelvin] = ConvertFahrenheitToKelvin,
            };

            int firstScaleValue = (int)SelectedFirstTemperatureScale;
            int secondScaleValue = (int)SelectedSecondTemperatureScale;

            ThermodynamicResultCallback calculate = calculateMethods[firstScaleValue + secondScaleValue];
            ThermodynamicResult result = calculate();

            Result = result.Data.ToString("F2");
            Details = result.Details;
            IsResultVisible = true;
        }
        
        public ThermodynamicResult ConvertCelsiusToFahrenheit()
        {
            bool invertValuePosition = SelectedFirstTemperatureScale == TemperatureScalesKind.Celsius;

            double calculationResult = invertValuePosition
                ? (FirstTemperature.Value * 9 / 5) + 32
                : (FirstTemperature.Value - 32) * 5 / 9;

            string formula = @$"R = \frac{{Tc}}{{5}} = \frac{{Tf - 32}}{{9}} =";
            string appliedFormula = invertValuePosition
                ? @$"R = \frac{{{(FirstTemperature.Value)}}}{{5}} = \frac{{Tf - 32}}{{9}} ="
                : @$"R = \frac{{Tc}}{{5}} = \frac{{{FirstTemperature.Value} - 32}}{{9}} =";
            string result = $"R = {calculationResult.ToString("F2")}";

            return new ThermodynamicResult()
            {
                Data = calculationResult,
                Details = new FormuledDetails()
                {
                    Explanation = "Aplicando a fórmula de conversão, obtemos o seguinte resultado:",
                    Expressions = new string[] { formula, appliedFormula, result }
                }
            };
        }

        public ThermodynamicResult ConvertCelsiusToKelvin()
        {
            bool invertValuePosition = SelectedFirstTemperatureScale == TemperatureScalesKind.Celsius;

            double calculationResult = invertValuePosition
                ? FirstTemperature.Value + 273.15
                : FirstTemperature.Value - 273.15;

            string formula = @$"R = \frac{{Tc}}{{5}} = \frac{{Tk - 273}}{{5}} =";
            string appliedFormula = invertValuePosition
                ? @$"R = \frac{{{(FirstTemperature.Value)}}}{{5}} = \frac{{Tk - 273}}{{5}} ="
                : @$"R = \frac{{Tc}}{{5}} = \frac{{{FirstTemperature.Value} - 273}}{{5}} =";
            string result = $"R = {calculationResult.ToString("F2")}";

            return new ThermodynamicResult()
            {
                Data = calculationResult,
                Details = new FormuledDetails()
                {
                    Explanation = "b",
                    Expressions = new string[] { formula, appliedFormula, result }
                }
            };
        }

        public ThermodynamicResult ConvertFahrenheitToKelvin()
        {
            bool firstTemperatureScaleIsFahrenheit = SelectedFirstTemperatureScale == TemperatureScalesKind.Fahrenheit;

            double calculationResult = firstTemperatureScaleIsFahrenheit
                ? (FirstTemperature.Value - 32) * 5 / 9 + 273.15
                : (FirstTemperature.Value - 273.15) * 9 / 5 + 32;

            string formula = @$"R = \frac{{Tf - 32}}{{9}} = \frac{{Tk - 273}}{{5}} =";
            string appliedFormula = firstTemperatureScaleIsFahrenheit
                ? @$"R = \frac{{{(FirstTemperature.Value)} - 32}}{{9}} = \frac{{Tk - 273}}{{5}} ="
                : @$"R = \frac{{Tf - 32}}{{9}} = \frac{{{FirstTemperature.Value} - 273}}{{5}} =";
            string result = $"R = {calculationResult.ToString("F2")}";

            return new ThermodynamicResult()
            {
                Data = calculationResult,
                Details = new FormuledDetails()
                {
                    Explanation = "Aplicando a fórmula de conversão, obtemos o seguinte resultado:",
                    Expressions = new string[] { formula, appliedFormula, result }
                }
            };
        }

    }
}