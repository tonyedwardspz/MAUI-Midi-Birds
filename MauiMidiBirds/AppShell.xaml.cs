namespace MauiMidiBirds;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(Views.LandingView), typeof(Views.LandingView));
        Routing.RegisterRoute(nameof(Views.PlayYourCardsView), typeof(Views.PlayYourCardsView));
    }
}

