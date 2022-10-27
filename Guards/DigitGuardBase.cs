using Caliburn.Micro;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Input;

namespace Gloomath.Guards
{
    public class DigitGuardBase : Screen
    {
        public void OnlyDigits(TextCompositionEventArgs e)
        {
            e.Handled = !Regex.IsMatch(e.Text, "[0-9]+");
        }

        public void AllowOnlyDigitsPaste(KeyEventArgs e)
        {
            if (e.Key == Key.Space)
            {
                e.Handled = true;
                return;
            }

            if (e.KeyboardDevice.Modifiers == ModifierKeys.Control && e.Key == Key.V)
            {
                IDataObject data = Clipboard.GetDataObject();
                string content = (string)data.GetData(DataFormats.Text);

                e.Handled = !Regex.IsMatch(content, "[0-9]+");
            }
        }
    }
}