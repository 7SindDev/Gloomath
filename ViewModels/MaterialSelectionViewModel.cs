using Caliburn.Micro;
using Gloomath.Models;

namespace Gloomath.ViewModels
{
    public class MaterialSelectionViewModel : Screen
    {
        private MaterialCard _currentMaterial;
        private int _currentMaterialIndex = 0;

        private MaterialCardRepository _materialCards = new MaterialCardRepository();

        private ShellViewModel _shellViewModel;

        public bool CanNext => CurrentMaterialIndex < _materialCards.Count - 1;
        public bool CanPrevious => CurrentMaterialIndex > 0;

        public MaterialCard CurrentMaterial
        {
            get
            {
                return _currentMaterial;
            }
            set
            {
                _currentMaterial = value;
                NotifyOfPropertyChange(() => CurrentMaterial);
            }
        }

        public int CurrentMaterialIndex
        {
            get
            {
                return _currentMaterialIndex;
            }
            set
            {
                _currentMaterialIndex = value;
                NotifyOfPropertyChange(() => CurrentMaterialIndex);
                NotifyOfPropertyChange(() => CanNext);
                NotifyOfPropertyChange(() => CanPrevious);
            }
        }

        public MaterialSelectionViewModel(ShellViewModel shellViewModel)
        {
            _shellViewModel = shellViewModel;
        }

        public void Access(object source)
        {
            ContentSelectionViewModel contentSelectionViewModel = IoC.Get<ContentSelectionViewModel>();

            contentSelectionViewModel.Contents.AddRange(CurrentMaterial.Contents);

            _shellViewModel.NavigateTo(contentSelectionViewModel, $"{CurrentMaterial.Title} >> Conteúdo(s)");
        }

        public void Next()
        {
            CurrentMaterial = _materialCards[++CurrentMaterialIndex];
        }

        public void Previous()
        {
            CurrentMaterial = _materialCards[--CurrentMaterialIndex];
        }

        protected override void OnViewLoaded(object view)
        {
            CurrentMaterial = _materialCards[CurrentMaterialIndex];
        }
    }
}