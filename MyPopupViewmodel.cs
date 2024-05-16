using System.Collections.ObjectModel;
using System.ComponentModel;

namespace MauiApp2;
public class MyPopupViewmodel : INotifyPropertyChanged
{
    private ObservableCollection<string>? _messages;

    public event PropertyChangedEventHandler? PropertyChanged;

    public ObservableCollection<string>? Messages
    {
        get => _messages;
        set
        {
            _messages = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Messages)));
        }
    }
}