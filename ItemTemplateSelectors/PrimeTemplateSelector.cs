using Gloomath.Models.PrimeCalculator;
using System.Windows;
using System.Windows.Controls;

namespace Gloomath.ItemTemplateSelectors
{
    public class PrimeTemplateSelector : DataTemplateSelector
    {
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            FrameworkElement element = container as FrameworkElement;

            if (element is null || item is not Value) return null;

            Value value = item as Value;

            string resourceKey = value.IsDivisible
                ? "IsDivisible"
                : "IsNotDivisible";

            return element.FindResource(resourceKey) as DataTemplate;
        }
    }
}