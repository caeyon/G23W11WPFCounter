using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace G23W11WPFCounter;

public class CounterViewModel : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;
    private CounterModel _model;

    public CounterViewModel() //생성자
    {
        _model = new CounterModel();
    }

    public int Value
    {
        get => _model.Count;
        set {
            _model.Count = value;
            OnPropertyChanged();
        }
    }

    private void OnPropertyChanged([CallerMemberName] String propName = "")
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
    }
}
