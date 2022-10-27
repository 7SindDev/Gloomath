using Caliburn.Micro;
using Gloomath.Guards;
using Gloomath.Models;
using System.Collections.Generic;
using System.Linq;

public enum ValueInputs
{
    One,
    Two,
    Three,
    Four,
    Five,
    Six
}

namespace Gloomath.ViewModels.Calculators
{
    public class MMCAndMDCCalculatorViewModel : DigitGuardBase
    {
        private BindableCollection<DataInput> _mmcInputs = new BindableCollection<DataInput>()
        {
            new DataInput(),
            new DataInput(),
            new DataInput(),
            new DataInput(),
            new DataInput(),
            new DataInput()
        };

        public BindableCollection<DataInput> MMCInputs
        {
            get
            {
                return _mmcInputs;
            }
            set
            {
                _mmcInputs = value;
                NotifyOfPropertyChange(() => MMCInputs);
            }
        }

        private BindableCollection<DataInput> _mdcInputs = new BindableCollection<DataInput>()
        {
            new DataInput(),
            new DataInput(),
            new DataInput(),
            new DataInput(),
            new DataInput(),
            new DataInput()
        };

        public BindableCollection<DataInput> MDCInputs
        {
            get
            {
                return _mdcInputs;
            }
            set
            {
                _mdcInputs = value;
                NotifyOfPropertyChange(() => MDCInputs);
            }
        }

        private bool _isMMCResultVisible;

        public bool IsMMCResultVisible
        {
            get
            {
                return _isMMCResultVisible;
            }
            set
            {
                _isMMCResultVisible = value;
                NotifyOfPropertyChange(() => IsMMCResultVisible);
            }
        }

        private bool _isMDCResultVisible;

        public bool IsMDCResultVisible
        {
            get
            {
                return _isMDCResultVisible;
            }
            set
            {
                _isMDCResultVisible = value;
                NotifyOfPropertyChange(() => IsMDCResultVisible);
            }
        }

        private string _mmcResult;

        public string MMCResult
        {
            get
            {
                return _mmcResult;
            }
            set
            {
                _mmcResult = value;
                NotifyOfPropertyChange(() => MMCResult);
            }
        }

        private string _mdcResult;

        public string MDCResult
        {
            get
            {
                return _mdcResult;
            }
            set
            {
                _mdcResult = value;
                NotifyOfPropertyChange(() => MDCResult);
            }
        }

        public void CalculateMMC()
        {
            List<double> values = (from input in MMCInputs
                                   where input.Value != string.Empty
                                   select double.Parse(input.Value)).ToList();

            MMCResult = MMCOf(values).ToString();
            IsMMCResultVisible = true;
        }

        public void CalculateMDC()
        {
            List<double> values = (from input in MDCInputs
                                   where input.Value != string.Empty
                                   select double.Parse(input.Value)).ToList();

            MDCResult = MDCOf(values).ToString();
            IsMDCResultVisible = true;
        }

        private double MMCOf(List<double> values)
        {
            double divisor = 2;
            List<double> divisors = new List<double>();

            while (values.Any(value => value != 1))
            {
                List<double> unfinishedValues = values.Where(value => value != 1).ToList();
                if (unfinishedValues.All(value => value % divisor != 0))
                {
                    divisor++;
                    continue;
                }

                for (int i = 0; i < values.Count; i++)
                {
                    double value = values[i];

                    if (value % divisor != 0) continue;

                    values[i] /= divisor;
                }

                divisors.Add(divisor);
            }

            return divisors.Count > 0
                ? divisors.Aggregate(1.0d, (acc, val) => acc * val)
                : 1;
        }

        private double MDCOf(List<double> values)
        {
            double divisor = 2;
            List<double> divisors = new List<double>();

            while (values.Any(value => value != 1))
            {
                List<double> unfinishedValues = values.Where(value => value != 1).ToList();
                if (unfinishedValues.All(value => value % divisor != 0))
                {
                    divisor++;
                    continue;
                }

                int divisionCount = 0;

                for (int i = 0; i < values.Count; i++)
                {
                    double value = values[i];

                    if (value % divisor != 0) continue;

                    values[i] /= divisor;
                    divisionCount++;
                }

                if (divisionCount == values.Count) divisors.Add(divisor);
            }

            return divisors.Aggregate(1.0d, (acc, val) => acc * val);
        }
    }
}