using System.Windows;

namespace Gloomath.Utils
{
    public static class Notifier
    {
        public static void NotifyError(string reason)
        {
            MessageBox.Show(reason, "Erro", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}