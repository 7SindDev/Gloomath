using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Markup;
using System.Windows.Media;

namespace Gloomath.Controls
{
    [ContentProperty("Items")]
    public class Calculator : Control
    {
        public static readonly DependencyProperty BaseColorProperty =
            DependencyProperty.Register("BaseColor", typeof(Brush), typeof(Calculator), new PropertyMetadata((new BrushConverter()).ConvertFromString("#D9D9D9")));

        public static readonly DependencyProperty ColumnsProperty =
             DependencyProperty.Register("Columns", typeof(int), typeof(Calculator), new PropertyMetadata(1));

        public static readonly DependencyProperty FirstColumnProperty =
            DependencyProperty.Register("FirstColumn", typeof(int), typeof(Calculator), new PropertyMetadata(0));

        public static readonly DependencyProperty ItemsProperty =
            DependencyProperty.Register("Items", typeof(ObservableCollection<CalculatorButton>), typeof(Calculator), new PropertyMetadata(new ObservableCollection<CalculatorButton>()));

        public static readonly DependencyProperty ExpressionProperty =
            DependencyProperty.Register("Expression", typeof(string), typeof(Calculator), new PropertyMetadata(string.Empty));

        public static readonly DependencyProperty OutputColorProperty =
            DependencyProperty.Register("OutputColor", typeof(Brush), typeof(Calculator), new PropertyMetadata((new BrushConverter()).ConvertFromString("#686868")));

        public static readonly DependencyProperty OutputProperty =
            DependencyProperty.Register("Output", typeof(string), typeof(Calculator), new PropertyMetadata("0"));

        public static readonly DependencyProperty RowsProperty =
            DependencyProperty.Register("Rows", typeof(int), typeof(Calculator), new PropertyMetadata(1));

        private UniformGrid Buttons;

        public Brush BaseColor
        {
            get { return (Brush)GetValue(BaseColorProperty); }
            set { SetValue(BaseColorProperty, value); }
        }

        public int Columns
        {
            get { return (int)GetValue(ColumnsProperty); }
            set { SetValue(ColumnsProperty, value); }
        }

        public int FirstColumn
        {
            get { return (int)GetValue(FirstColumnProperty); }
            set { SetValue(FirstColumnProperty, value); }
        }

        public ObservableCollection<CalculatorButton> Items
        {
            get { return (ObservableCollection<CalculatorButton>)GetValue(ItemsProperty); }
            set { SetValue(ItemsProperty, value); }
        }

        public string Expression
        {
            get { return (string)GetValue(ExpressionProperty); }
            set { SetValue(ExpressionProperty, value); }
        }

        public Brush OutputColor
        {
            get { return (Brush)GetValue(OutputColorProperty); }
            set { SetValue(OutputColorProperty, value); }
        }

        public string Output
        {
            get { return (string)GetValue(OutputProperty); }
            set { SetValue(OutputProperty, value); }
        }

        public int Rows
        {
            get { return (int)GetValue(RowsProperty); }
            set { SetValue(RowsProperty, value); }
        }

        static Calculator()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Calculator), new FrameworkPropertyMetadata(typeof(Calculator)));
        }

        public override void OnApplyTemplate()
        {
            Buttons = GetTemplateChild("Buttons") as UniformGrid;

            SetButtons();

            // Avoid repeated instances
            Items.Clear();

            base.OnApplyTemplate();
        }

        public void SetButtons()
        {
            foreach (CalculatorButton button in Items)
            {
                Buttons.Children.Add(button);
            }
        }
    }
}