using Caliburn.Micro;
using Gloomath.Models;

public enum DifficultiesKind
{
    Easy,
    Medium,
    Hard
};

namespace Gloomath.ViewModels.Practices
{
    public class PracticeConfigViewModel : Screen
    {
        private string _title;
        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                _title = value;
                NotifyOfPropertyChange(() => Title);
            }
        }

        private PracticeConfig _practiceConfig = new PracticeConfig();
        public PracticeConfig PracticeConfig
        {
            get
            {
                return _practiceConfig;
            }
            set
            {
                _practiceConfig = value;
                NotifyOfPropertyChange(() => PracticeConfig);
            }
        }

        public void Start()
        {
            ShellViewModel shellViewModel = IoC.Get<ShellViewModel>();
            SectionViewModel sectionViewModel = (SectionViewModel)shellViewModel.ActiveItem;

            shellViewModel.ActivateItemAsync(new StartedPracticeViewModel(sectionViewModel, PracticeConfig));
        }

        public void Difficulty(DifficultiesKind difficulty)
        {
            PracticeConfig.SelectedDifficulty = difficulty;
        }
    }
}