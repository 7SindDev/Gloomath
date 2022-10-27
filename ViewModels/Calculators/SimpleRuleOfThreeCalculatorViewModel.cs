using Gloomath.Guards;
using Gloomath.Models;

namespace Gloomath.ViewModels.Calculators
{
    public class SimpleRuleOfThreeCalculatorViewModel : DigitGuardBase
    {
        private DataInput<double> _firstData = new DataInput<double>();
        public DataInput<double> FirstData
        {
            get
            {
                return _firstData;
            }
            set
            {
                _firstData = value;
                NotifyOfPropertyChange(() => FirstData);
            }
        }

        private DataInput<double> _secondData = new DataInput<double>();
        public DataInput<double> SecondData
        {
            get
            {
                return _secondData;
            }
            set
            {
                _secondData = value;
                NotifyOfPropertyChange(() => SecondData);
            }
        }

        private DataInput<double> _thirdData = new DataInput<double>();
        public DataInput<double> ThirdData
        {
            get
            {
                return _thirdData;
            }
            set
            {
                _thirdData = value;
                NotifyOfPropertyChange(() => ThirdData);
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

        public void Calculate()
        {
            Result = (SecondData.Value * ThirdData.Value / FirstData.Value).ToString("F2");
        }
    }
}