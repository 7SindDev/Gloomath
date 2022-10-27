using Caliburn.Micro;
using Gloomath.Guards;
using Gloomath.Models;
using Gloomath.Models.PrimeCalculator;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Documents;

namespace Gloomath.ViewModels.Calculators
{
    public class ArithmeticAverageCalculatorViewModel : Screen
    {
		private BindableCollection<DataInput<double>> _valueInputs = new BindableCollection<DataInput<double>>() 
		{ 
			new DataInput<double>(),
			new DataInput<double>(),
			new DataInput<double>(),
			new DataInput<double>(),
			new DataInput<double>(),
			new DataInput<double>(),
			new DataInput<double>(),
			new DataInput<double>(),
		};
		public BindableCollection<DataInput<double>> ValueInputs
		{
			get
			{
				return _valueInputs;
			}
			set
			{
                _valueInputs = value;
				NotifyOfPropertyChange(() => ValueInputs);
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

		public void Calculate()
		{
			List<DataInput<double>> dataInputs = ValueInputs.Where(valueInput => valueInput.Value != 0).ToList();
			double result = (dataInputs.Sum(dataInput => dataInput.Value) / dataInputs.Count);

			Result = double.IsNaN(result) ? "0" : result.ToString("F2");
			IsResultVisible = true;
		}
	}
}