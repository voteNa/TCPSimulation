namespace NetworkSimulator.ViewModels
{
    public class ModelingParameters
    {
        public int FileSize { get; set; }

        public int ProtocolWindowSize { get; set; }

        public int ProtocolPackageSize { get; set; }

        public int ProtocolTimeout { get; set; }

        public double NetworkPackageDistortionProbability { get; set; }

        public double NetworkPackageLossProbability { get; set; }

        public DistributionType NetworkPackageTransmissionTimeDistribution { get; set; }

        public string NetworkPackageTransmissionTimeParameter { get; set; }

        public bool Visualize { get; set; }
    }
}
