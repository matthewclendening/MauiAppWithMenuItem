namespace MauiAppWithMenuItem;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        BindingContext = new ShellViewModel();
    }
}
