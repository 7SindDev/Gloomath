using Gloomath.Guards;
using Gloomath.Models.PotencyAndRootingCalculator;
using Gloomath.Utils;
using System;

namespace Gloomath.ViewModels.Calculators
{
    public class PotencyAndRootingCalculatorViewModel : DigitGuardBase
    {
        private SquareRoot _squareRoot = new SquareRoot() { Rooting = "2" };
        public SquareRoot SquareRoot
        {
            get
            {
                return _squareRoot;
            }
            set
            {
                _squareRoot = value;
                NotifyOfPropertyChange(() => SquareRoot);
            }
        }

        private Potency _potency = new Potency() { Base = "2", Exponent = "4" };
        public Potency Potency
        {
            get
            {
                return _potency;
            }
            set
            {
                _potency = value;
                NotifyOfPropertyChange(() => Potency);
            }
        }

        private string _squareRootResult = string.Empty;
        public string SquareRootResult
        {
            get
            {
                return _squareRootResult;
            }
            set
            {
                _squareRootResult = value;
                NotifyOfPropertyChange(() => SquareRootResult);
            }
        }

        private bool _isSquareRootResultVisible = false;
        public bool IsSquareRootResultVisible
        {
            get
            {
                return _isSquareRootResultVisible;
            }
            set
            {
                _isSquareRootResultVisible = value;
                NotifyOfPropertyChange(() => IsSquareRootResultVisible);
            }
        }

        private bool _isPotencyResultVisible = false;
        public bool IsPotencyResultVisible
        {
            get
            {
                return _isPotencyResultVisible;
            }
            set
            {
                _isPotencyResultVisible = value;
                NotifyOfPropertyChange(() => IsPotencyResultVisible);
            }
        }

        private string _potencyResult = string.Empty;
        public string PotencyResult
        {
            get
            {
                return _potencyResult;
            }
            set
            {
                _potencyResult = value;
                NotifyOfPropertyChange(() => PotencyResult);
            }
        }

        public void RootingCalculate()
        {
            string index = SquareRoot.Index is not null
                ? SquareRoot.Index.Content.ToString()
                : "2";

            if (SquareRoot.Rooting == string.Empty) return;

            string result = string.Empty;

            switch (index)
            {
                case "2":
                    result = Math.Sqrt(double.Parse(SquareRoot.Rooting)).ToString("F2");
                    break;

                case "3":
                    result = Math.Cbrt(double.Parse(SquareRoot.Rooting)).ToString("F2");
                    break;
            }

            if (double.Parse(result) > double.MaxValue)
            {
                Notifier.NotifyError("O resultado ultrapassou o limite de bytes.");
                return;
            }

            SquareRootResult = result;
            IsSquareRootResultVisible = true;
        }

        public void PotencyCalculate()
        {
            if (Potency.Base == string.Empty || Potency.Exponent == string.Empty) return;

            double potencyBase = double.Parse(Potency.Base);
            double potencyExponent = double.Parse(Potency.Exponent);

            double result = Math.Pow(potencyBase, potencyExponent);

            if (result > double.MaxValue)
            {
                Notifier.NotifyError($"O resultado ultrapassou o limite de bytes.");
                return;
            }

            PotencyResult = result.ToString();
            IsPotencyResultVisible = true;
        }
    }
}