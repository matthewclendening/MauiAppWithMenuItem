using CommunityToolkit.Mvvm.Messaging;

namespace MauiAppWithMenuItem;

public static class CounterService
{
    public static int Count { get; private set; }

    public static void Increment()
    {
        Count++;
        WeakReferenceMessenger.Default.Send(new CounterChangedMessage(Count));
    }
}