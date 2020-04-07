namespace NetworkSimulator.ViewModels
{
    public class ExperimentLogEntry
    {
        public int PackageNumber { get; set; }

        public int PackageSize { get; set; }

        public ExperimentPackageState State { get; set; }
    }
}