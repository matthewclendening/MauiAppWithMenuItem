using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Xml.Linq;
using CommunityToolkit.Mvvm.Messaging;

namespace MauiAppWithMenuItem;

public partial class MainViewModel : ObservableObject
{
    public string Count => CounterService.Count.ToString();


    [RelayCommand]
    public void IncrementCount()
    {
        CounterService.Increment();
        OnPropertyChanged(nameof(Count));
    }
}