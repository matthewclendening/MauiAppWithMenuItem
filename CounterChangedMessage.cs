using CommunityToolkit.Mvvm.Messaging.Messages;

namespace MauiAppWithMenuItem;

public class CounterChangedMessage : ValueChangedMessage<int>
{
    public CounterChangedMessage(int value) : base(value)
    {
    }
}