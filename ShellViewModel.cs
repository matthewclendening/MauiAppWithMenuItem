using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;

namespace MauiAppWithMenuItem;

public partial class ShellViewModel : ObservableObject, IRecipient<CounterChangedMessage>
{
    public ShellViewModel()
    {
        WeakReferenceMessenger.Default.Register<CounterChangedMessage>(this);
    }

    [RelayCommand(CanExecute = nameof(CanDoMyAction))]
    public void MyAction()
    {
        Shell.Current.FlyoutIsPresented = false;
    }

    private bool CanDoMyAction()
    {
        return CounterService.Count % 2 == 0;
    }

    public void Receive(CounterChangedMessage message)
    {
        MyActionCommand.NotifyCanExecuteChanged();
    }
}