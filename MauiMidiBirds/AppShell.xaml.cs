using CommunityToolkit.Maui.Views;

namespace MauiMidiBirds;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
    }

	public MediaElement GetPlayer()
    {
        return BirdPlayer;
    }
}

