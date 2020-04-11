using ReactiveUI;

namespace NetworkSimulator.ViewModels
{
    public class ModelingParameters : ViewModelBase
    {
        private int fileSize;
        private int protocolWindowSize;
        private int protocolPackageSize;
        private int protocolTimeout;
        private double networkPackageDistortionProbability;
        private double networkPackageLossProbability;
        private DistributionType networkPackageTransmissionTimeDistribution;
        private string networkPackageTransmissionTimeParameter;
        private int modelingExperimentCount;
        private bool visualize;

        public int FileSize
        {
            get => fileSize;
            set => this.RaiseAndSetIfChanged(ref this.fileSize, value);
        }

        public int ProtocolWindowSize
        {
            get => protocolWindowSize;
            set => this.RaiseAndSetIfChanged(ref this.protocolWindowSize, value);
        }

        public int ProtocolPackageSize
        {
            get => protocolPackageSize;
            set => this.RaiseAndSetIfChanged(ref this.protocolPackageSize, value);
        }

        public int ProtocolTimeout
        {
            get => protocolTimeout;
            set => this.RaiseAndSetIfChanged(ref this.protocolTimeout, value);
        }

        public double NetworkPackageDistortionProbability
        {
            get => networkPackageDistortionProbability;
            set => this.RaiseAndSetIfChanged(ref this.networkPackageDistortionProbability, value);
        }

        public double NetworkPackageLossProbability
        {
            get => networkPackageLossProbability;
            set => this.RaiseAndSetIfChanged(ref this.networkPackageLossProbability, value);
        }

        public DistributionType NetworkPackageTransmissionTimeDistribution
        {
            get => networkPackageTransmissionTimeDistribution;
            set => this.RaiseAndSetIfChanged(ref this.networkPackageTransmissionTimeDistribution, value);
        }

        public string NetworkPackageTransmissionTimeParameter
        {
            get => networkPackageTransmissionTimeParameter;
            set => this.RaiseAndSetIfChanged(ref this.networkPackageTransmissionTimeParameter, value);
        }

        public int ModelingExperimentCount
        {
            get => modelingExperimentCount;
            set => this.RaiseAndSetIfChanged(ref this.modelingExperimentCount, value);
        }

        public bool Visualize
        {
            get => visualize;
            set => this.RaiseAndSetIfChanged(ref this.visualize, value);
        }
    }
}
