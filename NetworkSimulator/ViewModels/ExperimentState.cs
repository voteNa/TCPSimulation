using System.Collections.ObjectModel;

namespace NetworkSimulator.ViewModels
{
    public class ExperimentState
    {
        public int Progress { get; set; }

        public ObservableCollection<ExperimentLogEntry> Log { get; set; }
    }
}
