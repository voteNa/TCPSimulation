using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using NetworkSimulator.ViewModels;

namespace NetworkSimulator.Views
{
    public class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        private void ShowStatisticsClick(Object sender, RoutedEventArgs args)
        {
            var statisticsWindow = new StatisticsWindow
            {
                DataContext = new StatisticsWindowViewModel()
            };

            statisticsWindow.Show();
        }
    }
}
