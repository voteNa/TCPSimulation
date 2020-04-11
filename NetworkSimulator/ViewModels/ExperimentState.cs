using System.Collections.ObjectModel;
using ReactiveUI;

namespace NetworkSimulator.ViewModels
{
    public class ExperimentState : ViewModelBase
    {
        private int progress;

        public int Progress
        {
            get => progress;
            set => this.RaiseAndSetIfChanged(ref this.progress, value);
        }

        public ObservableCollection<ExperimentLogEntry> Log { get; set; }
    }
}
