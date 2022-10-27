using MaterialDesignThemes.Wpf;
using System.Windows;
using System.Windows.Controls;

namespace Gloomath.Controls
{
    /// <summary>
    /// Interação lógica para MaterialContent.xam
    /// </summary>
    public partial class MaterialContent : UserControl
    {
        public static readonly DependencyProperty DescriptionProperty =
            DependencyProperty.Register("Description", typeof(string), typeof(MaterialContent), new PropertyMetadata(string.Empty));

        public static readonly DependencyProperty IconProperty =
            DependencyProperty.Register("Icon", typeof(PackIconKind), typeof(MaterialContent), new PropertyMetadata(null));

        public string Description
        {
            get { return (string)GetValue(DescriptionProperty); }
            set { SetValue(DescriptionProperty, value); }
        }

        public PackIconKind Icon
        {
            get { return (PackIconKind)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }

        public MaterialContent()
        {
            InitializeComponent();
        }
    }
}