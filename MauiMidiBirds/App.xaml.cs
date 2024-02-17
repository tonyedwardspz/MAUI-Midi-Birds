namespace MauiMidiBirds;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();

		Routing.RegisterRoute(nameof(Views.LandingView), typeof(Views.LandingView));
        Routing.RegisterRoute(nameof(Views.PlayYourCardsView), typeof(Views.PlayYourCardsView));
	}
}

