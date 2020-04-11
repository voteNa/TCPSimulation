using System;
using System.Windows.Input;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using ReactiveUI;

namespace NetworkSimulator.ViewModels
{
    public class StatisticsWindowViewModel : ViewModelBase
    {
        private PlotModel plot;

        public StatisticsWindowViewModel()
        {
            this.SetFileTransmissionTimeDistributionCommand = ReactiveCommand.Create(this.SetFileTransmissionTimeDistribution);
            this.SetRedundantTransmissionCountDistributionCommand = ReactiveCommand.Create(this.SetRedundantTransmissionCountDistribution);
            this.SetRetransmissionCountDistributionCommand = ReactiveCommand.Create(this.SetRetransmissionCountDistribution);

            this.SaveAllCommand = ReactiveCommand.Create(this.SaveAll);
            this.SaveSourceDataCommand = ReactiveCommand.Create(this.SaveSourceData);
            this.SaveChartCommand = ReactiveCommand.Create(this.SaveChart);
            this.SaveChartAsDataCommand = ReactiveCommand.Create(this.SaveChartAsData);
        }
        public PlotModel Plot
        {
            get => plot;
            set => this.RaiseAndSetIfChanged(ref this.plot, value);
        }

        // Команды для переключения графиков
        public ICommand SetFileTransmissionTimeDistributionCommand { get; }
        public ICommand SetRedundantTransmissionCountDistributionCommand { get; }
        public ICommand SetRetransmissionCountDistributionCommand { get; }

        // Команды для сохранения графиков
        public ICommand SaveAllCommand { get; }
        public ICommand SaveSourceDataCommand { get; }
        public ICommand SaveChartCommand { get; }
        public ICommand SaveChartAsDataCommand { get; }


        private void SetFileTransmissionTimeDistribution()
        {
            var plot = new PlotModel
            {
                Title = "Эмпирическое распределение времени передачи файла"
            };

            plot.Axes.Add(new LinearAxis
            {
                Key = "xAxis",
                Title = "Время передачи",
                Position = AxisPosition.Bottom,
            });

            plot.Axes.Add(new LinearAxis
            {
                Key = "yAxis",
                Title = "Частота повторных передач",
                Position = AxisPosition.Left,
            });

            plot.Series.Add(new FunctionSeries(Math.Cos, 0, 10, 0.1, "cos(x)"));
            this.Plot = plot;
        }

        private void SetRedundantTransmissionCountDistribution()
        {
            var plot = new PlotModel
            {
                Title = "Эмпирическое распределение числа избыточных передач"
            };

            plot.Axes.Add(new LinearAxis
            {
                Key = "xAxis",
                Title = "Число избыточных передач",
                Position = AxisPosition.Bottom,
            });

            plot.Axes.Add(new LinearAxis
            {
                Key = "yAxis",
                Title = "Частота повторных передач",
                Position = AxisPosition.Left,
            });

            plot.Series.Add(new FunctionSeries(Math.Cos, 0, 10, 0.1, "cos(x)"));
            this.Plot = plot;
        }

        private void SetRetransmissionCountDistribution()
        {
            var plot = new PlotModel
            {
                Title = "Эмпирическое распределение числа повторных передач"
            };

            plot.Axes.Add(new LinearAxis
            {
                Key = "xAxis",
                Title = "Число повторных передач",
                Position = AxisPosition.Bottom,
            });

            plot.Axes.Add(new LinearAxis
            {
                Key = "yAxis",
                Title = "Частота повторных передач",
                Position = AxisPosition.Left,
            });

            plot.Series.Add(new FunctionSeries(Math.Cos, 0, 10, 0.1, "cos(x)"));
            this.Plot = plot;
        }

        private void SaveAll()
        {
            // Логика для действия "Сохранить все"
        }

        private void SaveSourceData()
        {
            // Логика для действия "Сохранить исходные данные"
        }

        private void SaveChart()
        {
            // Логика для действия "Сохранить гистограмму"
        }

        private void SaveChartAsData()
        {
            // Логика для действия "Сохранить гистограмму как данные"
        }
    }
}
