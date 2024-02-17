using MauiMidiBirds.ViewModels;

namespace MauiMidiBirds.Views;

public partial class PlayYourCardsView : ContentPage
{
	public PlayYourCardsView()
	{
		InitializeComponent();
		BindingContext = new PlayYourCardsViewModel();
	}
}
