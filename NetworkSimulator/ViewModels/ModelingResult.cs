using ReactiveUI;

namespace NetworkSimulator.ViewModels
{
    public class ModelingResult : ViewModelBase
    {
        private double transmissionTime;
        private int retriesCount;
        private int redundantTransmissionsCount;
        private int experimentsCount;

        public double TransmissionTime
        {
            get => transmissionTime;
            set => this.RaiseAndSetIfChanged(ref this.transmissionTime, value);
        }

        public int RetriesCount
        {
            get => retriesCount;
            set => this.RaiseAndSetIfChanged(ref this.retriesCount, value);
        }

        public int RedundantTransmissionsCount
        {
            get => redundantTransmissionsCount;
            set => this.RaiseAndSetIfChanged(ref this.redundantTransmissionsCount, value);
        }

        public int ExperimentsCount
        {
            get => experimentsCount;
            set => this.RaiseAndSetIfChanged(ref this.experimentsCount, value);
        }
    }
}
