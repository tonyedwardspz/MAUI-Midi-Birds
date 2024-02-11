namespace MauiMidiBirds.Views;

using MauiMidiBirds.ViewModels;

public partial class LandingView : ContentPage
{
	public LandingView()
	{
		InitializeComponent();
		BindingContext = new LandingViewModel();
	}
}
