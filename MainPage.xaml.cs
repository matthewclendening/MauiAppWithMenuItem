namespace MauiAppWithMenuItem;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
        BindingContext = ServiceHelper.GetService<MainViewModel>();
    }
}

