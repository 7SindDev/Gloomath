using Caliburn.Micro;
using System.Windows;

namespace Gloomath.ViewModels
{
    public class ShellViewModel : Conductor<object>
    {
        private string _currentActiveItemTitle;

        public string CurrentActiveItemTitle
        {
            get
            {
                return _currentActiveItemTitle;
            }
            set
            {
                _currentActiveItemTitle = value;
                NotifyOfPropertyChange(() => CurrentActiveItemTitle);
            }
        }

        public void Exit()
        {
            Application.Current.Shutdown();
        }

        public async void NavigateTo(object viewModel, string title)
        {
            await ActivateItemAsync(viewModel);

            CurrentActiveItemTitle = title;
        }

        public void NavigateToAboutViewModel()
        {
            NavigateTo(IoC.Get<AboutViewModel>(), "Sobre");
        }

        public void NavigateToMaterialSelectionViewModel()
        {
            NavigateTo(IoC.Get<MaterialSelectionViewModel>(), "Matérias");
        }
    }
}