using System.Collections.ObjectModel;

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
        }

        public ModelingParameters Parameters { get; set; }

        public ExperimentState Experiment { get; set; }

        public ModelingResult Result { get; set; }
    }
}
