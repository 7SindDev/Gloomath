using Caliburn.Micro;
using Gloomath.Models;
using Gloomath.ViewModels.Practices;

namespace Gloomath.ViewModels
{
    public class SectionViewModel : Conductor<object>
    {
        public Content Content { get; protected set; }

        public SectionViewModel(Content content)
        {
            Content = content;
        }

        public async void GoToPracticeView(object source)
        {
            await ActivateItemAsync(IoC.Get<PracticeConfigViewModel>());
        }

        public async void GoToCalculatorView(object source)
        {
            await ActivateItemAsync(Content.Section.CalculatorViewModel);
        }
    }
}