using MaterialDesignThemes.Wpf;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Gloomath.Controls
{
    /// <summary>
    /// Interação lógica para CalculatorButton.xam
    /// </summary>
    public partial class CalculatorButton : UserControl
    {
        public static readonly DependencyProperty ActionProperty =
            DependencyProperty.Register("Action", typeof(string), typeof(CalculatorButton), new PropertyMetadata(null));

        public static readonly DependencyProperty BackColorProperty =
            DependencyProperty.Register("BackColor", typeof(Brush), typeof(CalculatorButton), new PropertyMetadata(Brushes.White));

        public static readonly DependencyProperty ForeColorProperty =
            DependencyProperty.Register("ForeColor", typeof(Brush), typeof(CalculatorButton), new PropertyMetadata(Brushes.Black));

        public static readonly DependencyProperty IconColorProperty =
            DependencyProperty.Register("IconColor", typeof(Brush), typeof(CalculatorButton), new PropertyMetadata(Brushes.Black));

        public static readonly DependencyProperty IconProperty =
            DependencyProperty.Register("Icon", typeof(PackIconKind), typeof(CalculatorButton), new PropertyMetadata(null));

        public static readonly DependencyProperty LabelProperty =
            DependencyProperty.Register("Label", typeof(object), typeof(CalculatorButton), new PropertyMetadata(null));

        public string Action
        {
            get { return (string)GetValue(ActionProperty); }
            set { SetValue(ActionProperty, value); }
        }

        public Brush BackColor
        {
            get { return (Brush)GetValue(BackColorProperty); }
            set { SetValue(BackColorProperty, value); }
        }

        public Brush ForeColor
        {
            get { return (Brush)GetValue(ForeColorProperty); }
            set { SetValue(ForeColorProperty, value); }
        }

        public PackIconKind Icon
        {
            get { return (PackIconKind)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }

        public Brush IconColor
        {
            get { return (Brush)GetValue(IconColorProperty); }
            set { SetValue(IconColorProperty, value); }
        }

        public object Label
        {
            get { return (object)GetValue(LabelProperty); }
            set { SetValue(LabelProperty, value); }
        }

        public CalculatorButton()
        {
            InitializeComponent();
        }
    }
}