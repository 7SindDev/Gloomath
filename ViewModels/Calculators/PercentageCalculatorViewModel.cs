using Gloomath.Guards;

namespace Gloomath.ViewModels.Calculators
{
    public class PercentageCalculatorViewModel : DigitGuardBase
    {
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

        private string _percentage;
        public string Percentage
        {
            get
            {
                return _percentage;
            }
            set
            {
                _percentage = value;
                NotifyOfPropertyChange(() => Percentage);
            }
        }

        private string _value;
        public string Value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
                NotifyOfPropertyChange(() => Value);
            }
        }

        public void Calculate()
        {
            Result = (double.Parse(Percentage) / 100 * double.Parse(Value)).ToString("F2");
            IsResultVisible = true;
        }
    }
}