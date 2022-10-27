using Caliburn.Micro;
using Gloomath.Models;
using Gloomath.Models.PrimeCalculator;
using Gloomath.Utils;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Input;

namespace Gloomath.ViewModels.Calculators
{
    public class PrimeCalculatorViewModel : Screen
    {
        private BindableCollection<Value> _values = new BindableCollection<Value>();

        public BindableCollection<Value> Values
        {
            get
            {
                return _values;
            }
            set
            {
                _values = value;
                NotifyOfPropertyChange(() => Values);
            }
        }

        private DataInput _dataInput = new DataInput();
        public DataInput DataInput
        {
            get
            {
                return _dataInput;
            }
            set
            {
                _dataInput = value;
                NotifyOfPropertyChange(() => DataInput);
            }
        }

        private string _value = "0";
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

        private int _divisibleValuesQuantity = 0;
        public int DivisibleValuesQuantity
        {
            get
            {
                return _divisibleValuesQuantity;
            }
            set
            {
                _divisibleValuesQuantity = value;
                NotifyOfPropertyChange(() => DivisibleValuesQuantity);
            }
        }

        private bool _isPrime;
        public bool IsPrime
        {
            get
            {
                return _isPrime;
            }
            set
            {
                _isPrime = value;
                NotifyOfPropertyChange(() => IsPrime);
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

        private string CurrentValue;

        public void Verify()
        {
            if (CurrentValue == DataInput.Value) return;
            if (DataInput.Value == "1" || DataInput.Value == "0")
            {
                CurrentValue = DataInput.Value;
                Value = DataInput.Value;
                IsPrime = false;
                IsResultVisible = true;
                return;
            }

            if (DataInput.Value == string.Empty) return;

            int value;
            bool isValid = int.TryParse(DataInput.Value.Trim(), out value);

            if (!isValid)
            {
                Notifier.NotifyError($"O valor de entrada máximo é {int.MaxValue}.");
                return;
            }

            IsResultVisible = true;
            Value = DataInput.Value;

            AddValues(value);

            IsPrime = !HasDivisible();

            IsResultVisible = true;
            CurrentValue = Value;
        }

        private void AddValues(int value)
        {
            Values.Clear();

            for (int i = 2; i < value; i++)
            {
                Values.Add(new Value() { Data = i, IsDivisible = value % i == 0 });
            }

            DivisibleValuesQuantity = Values.Count(value => value.IsDivisible);
        }

        public void PreviewResultInput(TextCompositionEventArgs e)
        {
            e.Handled = !Regex.IsMatch(e.Text, "[0-9]+");
        }

        private bool HasDivisible()
        {
            return Values.Any(value => value.IsDivisible);
        }
    }
}