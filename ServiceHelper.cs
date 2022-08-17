
namespace MauiAppWithMenuItem;

public static class ServiceHelper
{
    public static TService GetService<TService>() => Current.GetService<TService>();

    public static IServiceProvider Current =>
#if ANDROID
        MauiApplication.Current.Services;
#elif IOS || MACCATALYST
        MauiUIApplicationDelegate.Current.Services;
#elif WINDOWS
        MauiWinUIApplication.Current.Services;
#else
        null;
#endif
}