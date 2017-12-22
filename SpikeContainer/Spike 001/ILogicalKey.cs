using System.ComponentModel;

namespace SpikeContainer.Spike_001
{
    public interface ILogicalKey : INotifyPropertyChanged
    {
        string DisplayName { get; }
        void Press();
        event LogicalKeyPressedEventHandler LogicalKeyPressed;
    }
}