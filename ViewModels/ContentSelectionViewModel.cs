using Caliburn.Micro;
using Gloomath.Models;

namespace Gloomath.ViewModels
{
    public class ContentSelectionViewModel : Screen
    {
        private BindableCollection<Content> _contents = new BindableCollection<Content>();
        private ShellViewModel _shellViewModel;

        public BindableCollection<Content> Contents
        {
            get
            {
                return _contents;
            }
            set
            {
                _contents = value;
                NotifyOfPropertyChange(() => Contents);
            }
        }

        public ContentSelectionViewModel(ShellViewModel shellViewModel)
        {
            _shellViewModel = shellViewModel;
        }

        public void Access(object source)
        {
            Content model = (Content)source;

            _shellViewModel.NavigateTo(new SectionViewModel(model), $"{model.Label} >> Seção");
        }
    }
}