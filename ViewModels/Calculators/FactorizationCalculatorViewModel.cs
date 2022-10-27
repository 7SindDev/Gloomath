using Gloomath.Guards;
using Gloomath.Models;
using Gloomath.Models.PotencyAndRootingCalculator;
using Gloomath.Utils;
using org.mariuszgromada.math.mxparser;
using System.Collections.Generic;

namespace Gloomath.ViewModels.Calculators
{
    public class FactorizationCalculatorViewModel : DigitGuardBase
    {
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

        public void Verify()
        {
            int value;
            bool isValid = int.TryParse(DataInput.Value.Trim(), out value);

            if (!isValid)
            {
                Notifier.NotifyError($"O valor de entrada máximo é {int.MaxValue}.");
                return;
            }

            Result = string.Empty;

            List<Potency> potencies = Factorize(value);
            DisplayResult(potencies);

            IsResultVisible = true;
        }

        private void DisplayResult(List<Potency> potencies)
        {
            for (int i = 0; i < potencies.Count; i++)
            {
                Potency potency = potencies[i];

                Result += (i == potencies.Count - 1)
                    ? $"{potency.Base}^{{{potency.Exponent}}}"
                    : $"{potency.Base}^{{{potency.Exponent}}} * ";
            }
        }

        public List<Potency> Factorize(int value)
        {
            List<Potency> output = new List<Potency>();

            int divisor = 2;

            while (value != 1)
            {
                Expression exp = new Expression($"ispr({value})");

                bool isPrime = exp.calculate() == 1.0d;
                if (isPrime) divisor = value;

                if (value % divisor != 0)
                {
                    divisor++;
                    continue;
                }

                // Avoid adding multiple instances of potencies (2 * 2 * 2 * 2 * x...), just incrementing the exponent (2 ^ x)
                bool hasExistentProperty = CheckExistentPotency(output, divisor, ref value);

                if (value == 1) break;
                if (!hasExistentProperty) output.Add(new Potency() { Base = $"{divisor}", Exponent = "1" });

                value /= divisor;
            }

            return output;
        }

        private bool CheckExistentPotency(List<Potency> potencies, int divisor, ref int value)
        {
            Potency? existentPotency = potencies.Find(potency => potency.Base == divisor.ToString());

            if (existentPotency is not null)
            {
                existentPotency.Exponent = (int.Parse(existentPotency.Exponent) + 1).ToString();
                return true;
            }

            return false;
        }
    }
}