using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace NetworkSimulator.Views
{
    public class StatisticsWindow : Window
    {
        public StatisticsWindow()
        {
            this.InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
