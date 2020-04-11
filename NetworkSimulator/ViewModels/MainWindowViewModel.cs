using System.Collections.ObjectModel;
using System.Windows.Input;
using ReactiveUI;

namespace NetworkSimulator.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
            this.Parameters = new ModelingParameters
            {
                FileSize = 450,
                ProtocolWindowSize = 25,
                ProtocolPackageSize = 25,
                ProtocolTimeout = 1,
                NetworkPackageDistortionProbability = 0,
                NetworkPackageLossProbability = 0.0005,
                NetworkPackageTransmissionTimeDistribution = DistributionType.Exponential,
                NetworkPackageTransmissionTimeParameter = "1",
                ModelingExperimentCount = 10,
                Visualize = true,
            };

            this.Experiment = new ExperimentState
            {
                Progress = 42,
                Log = new ObservableCollection<ExperimentLogEntry>
                {
                    new ExperimentLogEntry {PackageNumber = 45, PackageSize = 1500, State = ExperimentPackageState.Success},
                    new ExperimentLogEntry {PackageNumber = 46, PackageSize = 1500, State = ExperimentPackageState.Success},
                    new ExperimentLogEntry {PackageNumber = 47, PackageSize = 1500, State = ExperimentPackageState.Success},
                    new ExperimentLogEntry {PackageNumber = 48, PackageSize = 1500, State = ExperimentPackageState.Fail},
                    new ExperimentLogEntry {PackageNumber = 49, PackageSize = 1500, State = ExperimentPackageState.Success},
                    new ExperimentLogEntry {PackageNumber = 50, PackageSize = 1500, State = ExperimentPackageState.Success},
                    new ExperimentLogEntry {PackageNumber = 51, PackageSize = 1500, State = ExperimentPackageState.Success},
                    new ExperimentLogEntry {PackageNumber = 52, PackageSize = 1500, State = ExperimentPackageState.Fail},
                    new ExperimentLogEntry {PackageNumber = 53, PackageSize = 1500, State = ExperimentPackageState.Fail},
                    new ExperimentLogEntry {PackageNumber = 54, PackageSize = 1500, State = ExperimentPackageState.Success},
                }
            };

            this.StartCommand = ReactiveCommand.Create(this.Start);
            this.StopCommand = ReactiveCommand.Create(this.Stop );
        }

        public ICommand StartCommand { get; }
        public ICommand StopCommand { get; }

        public ModelingParameters Parameters { get; set; }

        public ExperimentState Experiment { get; set; }

        public ModelingResult Result { get; set; }

        private void Start()
        {
            // Логика для действия "Старт"
            if (this.Experiment.Progress < 100)
            {
                this.Experiment.Progress++;
            }
        }

        private void Stop()
        {
            // Логика для действия "Стоп"
            this.Experiment.Progress = 0;
        }
    }
}
