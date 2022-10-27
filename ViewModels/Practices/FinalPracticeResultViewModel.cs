using Caliburn.Micro;
using Gloomath.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;

namespace Gloomath.ViewModels.Practices
{
    public class FinalPracticeResultViewModel : Screen
    {
        private SectionViewModel SectionViewModel;

        private PracticeResult _result;
        public PracticeResult Result
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

        public FinalPracticeResultViewModel(SectionViewModel sectionViewModel, PracticeResult result)
        {
            Result = result;
            SectionViewModel = sectionViewModel;
        }

        public async void Back()
        {
            ShellViewModel shellViewModel = IoC.Get<ShellViewModel>();

            await shellViewModel.ActivateItemAsync(SectionViewModel);
        }
    }
}