using Caliburn.Micro;
using Gloomath.Models;
using Gloomath.Models.KinematicCalculator;
using System;
using System.Collections.Generic;

namespace Gloomath.ViewModels.Calculators
{
	public class KinematicCalculatorViewModel : Screen
    {
		private Velocity _velocity = new Velocity();
		public Velocity Velocity
		{
			get
			{
				return _velocity;
			}
			set
			{
				_velocity = value;
				NotifyOfPropertyChange(() => Velocity);
			}
		}

		private Deslocation _deslocation = new Deslocation();
		public Deslocation Deslocation
		{
			get
			{
				return _deslocation;
			}
			set
			{
				_deslocation = value;
				NotifyOfPropertyChange(() => Deslocation);
			}
		}

		private Time _time = new Time();
		public Time Time
		{
			get
			{
				return _time;
			}
			set
			{
				_time = value;
				NotifyOfPropertyChange(() => Time);
			}
		}

		private bool _isVelocityInputEnabled;
		public bool IsVelocityInputEnabled
		{
			get
			{
				return _isVelocityInputEnabled;
			}
			set
			{
				_isVelocityInputEnabled = value;
				NotifyOfPropertyChange(() => IsVelocityInputEnabled);
			}
		}

		private bool _isDeslocationInputEnabled;
		public bool IsDeslocationInputEnabled
		{
			get
			{
				return _isDeslocationInputEnabled;
			}
			set
			{
				_isDeslocationInputEnabled = value;
				NotifyOfPropertyChange(() => IsDeslocationInputEnabled);
			}
		}

		private bool _isTimeInputEnabled;
		public bool IsTimeInputEnabled
		{
			get
			{
				return _isTimeInputEnabled;
			}
			set
			{
				_isTimeInputEnabled = value;
				NotifyOfPropertyChange(() => IsTimeInputEnabled);
			}
		}

		private string _result;
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

		private bool _isResultVisible;
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

		private string _selectedValueInputDisabled;
		public string SelectedValueInputDisabled
		{
			get
			{
				return _selectedValueInputDisabled;
			}
			set
			{
				_selectedValueInputDisabled = value;
				NotifyOfPropertyChange(() => SelectedValueInputDisabled);
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

		public KinematicCalculatorViewModel()
		{
			DeactivateVelocityInput();
		}

		public void DeactivateVelocityInput()
		{
			IsVelocityInputEnabled = false;
			IsDeslocationInputEnabled = true;
			IsTimeInputEnabled = true;

			SelectedValueInputDisabled = nameof(IsVelocityInputEnabled);
		}

		public void DeactivateDeslocationInput()
		{
            IsVelocityInputEnabled = true;
            IsDeslocationInputEnabled = false;
            IsTimeInputEnabled = true;

			SelectedValueInputDisabled = nameof(IsDeslocationInputEnabled);
        }

		public void DeactivateTimeInput()
		{
            IsVelocityInputEnabled = true;
            IsDeslocationInputEnabled = true;
            IsTimeInputEnabled = false;

			SelectedValueInputDisabled = nameof(IsTimeInputEnabled);
        }

		public void Calculate()
		{
			Dictionary<string, Func<KinematicResult>> calculateMethods = new Dictionary<string, Func<KinematicResult>>()
			{
				[nameof(IsVelocityInputEnabled)] = DiscoverVelocity,
				[nameof(IsDeslocationInputEnabled)] = DiscoverDeslocation,
				[nameof(IsTimeInputEnabled)] = DiscoverTime
			};

            Func<KinematicResult> calculate = calculateMethods[SelectedValueInputDisabled];

			KinematicResult result = calculate();
			Result = result.Data.ToString("F2");

			Details.Explanation = result.Details.Explanation;
			Details.Expression = result.Details.Expression;
			NotifyOfPropertyChange(() => Details);

			IsResultVisible = true;
		}

		public KinematicResult DiscoverVelocity()
		{
			double result = Deslocation.Value / Time.Value;

			return new KinematicResult()
			{
				Data = result,

				Details = new Details()
				{
					Explanation = $"Sabendo que a variação da deslocação é {Deslocation.Value}m e a variação do tempo é {Time.Value}s, aplicando a fórmula para achar a velocidade média, obtemos {result.ToString("F2")}m/s.",
					Expression = @$"Vm = \frac{{\Delta S}}{{\Delta T}} = \frac{{{Deslocation.Value}}}{{{Time.Value}}} = {result.ToString("F2")}"
				}
			};
		}

		public KinematicResult DiscoverDeslocation()
		{
            double result = Velocity.Value * Time.Value;

            return new KinematicResult()
            {
                Data = result,

                Details = new Details()
                {
                    Explanation = $"Sabendo que a velocidade média é {Velocity.Value}m/s e a variação do tempo é {Time.Value}s, aplicando a fórmula para achar a variação do deslocamento, obtemos {result.ToString("F2")}m.",
                    Expression = @$"\Delta S = Vm * \Delta T = {Velocity.Value} * {Time.Value} = {result.ToString("F2")}"
                }
            };
        }

		public KinematicResult DiscoverTime()
		{
            double result = Deslocation.Value / Velocity.Value;

            return new KinematicResult()
            {
                Data = result,

                Details = new Details()
                {
                    Explanation = $"Sabendo que a variação do deslocamento é {Deslocation.Value}m e a velocidade média é {Velocity.Value}s, aplicando a fórmula para achar a variação do tempo, obtemos {result.ToString("F2")}s.",
                    Expression = @$"\Delta T = \frac{{\Delta S}}{{Vm}} = \frac{{{Deslocation.Value}}}{{{Velocity.Value}}} = {result.ToString("F2")}"
                }
            };
        }
	}
}