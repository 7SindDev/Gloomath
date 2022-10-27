using Caliburn.Micro;
using Gloomath.Models;
using org.mariuszgromada.math.mxparser;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Gloomath.ViewModels.Calculators
{
    public class ArithmeticOperationsCalculatorViewModel : Screen
    {
        private const int MAX_DIGITS = 16;
        private string _expression = string.Empty;
        private bool _isOperatorsEnabled = true;
        private string _output = "0";
        private string CurrentSignal = string.Empty;
        private bool IsSecondNumber = false;

        private BindableCollection<CalculatorHistory> _calculatorHistories = new BindableCollection<CalculatorHistory>();

        public BindableCollection<CalculatorHistory> CalculatorHistories
        {
            get
            {
                return _calculatorHistories;
            }
            set
            {
                _calculatorHistories = value;
                NotifyOfPropertyChange(() => CalculatorHistories);
            }
        }

        public string Expression
        {
            get
            {
                return _expression;
            }
            set
            {
                _expression = value;
                NotifyOfPropertyChange(() => Expression);
            }
        }

        public bool IsOperatorsEnabled
        {
            get
            {
                return _isOperatorsEnabled;
            }
            set
            {
                _isOperatorsEnabled = value;
                NotifyOfPropertyChange(() => IsOperatorsEnabled);
            }
        }

        public string Output
        {
            get
            {
                return _output;
            }
            set
            {
                _output = value;
                NotifyOfPropertyChange(() => Output);
            }
        }

        private bool _isEmptyHistory = true;

        public bool IsEmptyHistory
        {
            get
            {
                return _isEmptyHistory;
            }
            set
            {
                _isEmptyHistory = value;
                NotifyOfPropertyChange(() => IsEmptyHistory);
            }
        }

        public void Backspace()
        {
            if (!IsOperatorsEnabled)
            {
                IsOperatorsEnabled = true;
                CClear();
            }

            if (Output.Length <= 1)
            {
                if (Output == "0") return;
                if (Output != "0") Output = "0"; return;
            }

            if (Expression.Contains("="))
            {
                Expression = string.Empty; return;
            }

            Output = Output.Remove(Output.Length - 1);
        }

        public void CClear()
        {
            IsOperatorsEnabled = true;

            Output = "0";
            Expression = string.Empty;
            CurrentSignal = string.Empty;
            IsSecondNumber = false;
        }

        public void CEClear()
        {
            if (!IsOperatorsEnabled) IsOperatorsEnabled = true;
            if (Expression == string.Empty || Expression.Contains("="))
            {
                CClear();
                return;
            }

            Output = "0";
        }

        public void Comma()
        {
            if (Output.Contains(".")) return;

            Output += ".";
        }

        public void Digit(string number)
        {
            if (!IsOperatorsEnabled)
            {
                IsOperatorsEnabled = true;
                CClear();
            }

            if (IsSecondNumber)
            {
                Output = number;
                IsSecondNumber = false;
                return;
            }

            if (Output.Length >= MAX_DIGITS) return;
            // Avoid repeated zeros
            if (number == "0" && Output == "0") return;

            if (Expression.Contains("=")) CClear();

            Output = Output == "0"
                ? number
                : Output + number;
        }

        public void Equal()
        {
            if (Expression is null) return;

            // Avoid division by zero
            if (Output == "0" && CurrentSignal == "/" && IsOperatorsEnabled)
            {
                Output = "Não é possível dividir por zero.";
                IsOperatorsEnabled = false;
                return;
            }

            Regex VALUE_AFTER_POINT_REGEX = new Regex(@"(?<=\.)[0-9]+", RegexOptions.Multiline);
            bool hasValueAfterPoint = VALUE_AFTER_POINT_REGEX.IsMatch(Output);

            if (Output.Contains(".") && !hasValueAfterPoint) Output = Output.Remove(Output.Length - 1);

            UpdateOperationPreview();

            Output = Solve(Expression).ToString();
            Expression += "=";
            IsSecondNumber = false;
            CalculatorHistories.Add(new CalculatorHistory()
            {
                Expression = Expression,
                Output = Output
            });
            IsEmptyHistory = false;
        }

        public void Operator(string signal)
        {
            bool isSameSignal = Expression.Contains(signal) && !Expression.Contains("=");

            if (isSameSignal)
            {
                Output = Solve(Expression + $"{Output}");
            }

            Expression = $"{Output} {signal}";
            CurrentSignal = signal;
            IsSecondNumber = true;
        }

        public void PlusMinus()
        {
            if (Output == "0") return;

            double invertedResultSignal = double.Parse(Output, CultureInfo.InvariantCulture) * (-1.0d);

            Output = invertedResultSignal.ToString(CultureInfo.InvariantCulture);
        }

        private string Solve(string expression)
        {
            Expression output = new Expression(expression);

            return output.calculate().ToString("F2", CultureInfo.InvariantCulture);
        }

        public void ClearHistory()
        {
            CalculatorHistories.Clear();
            IsEmptyHistory = true;
        }

        public void ShowHistory(CalculatorHistory history)
        {
            Expression = history.Expression;
            Output = history.Output;
        }

        private void UpdateOperationPreview()
        {
            bool containsCurrentSignal = CurrentSignal != string.Empty && Expression.Contains(CurrentSignal);

            // Multiplying the current output by second number if the client clicks on Equal more than one time
            if (containsCurrentSignal && Expression.Contains("="))
            {
                var secondNumber = Expression.Split(" ")[2];

                Expression = $"{Output} {CurrentSignal} {secondNumber} ";
                return;
            }

            Expression = containsCurrentSignal
                ? $"{Expression} {Output} "
                : $" {Output} ";
        }
    }
}