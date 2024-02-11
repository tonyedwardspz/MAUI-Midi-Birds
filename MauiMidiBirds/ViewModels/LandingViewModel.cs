using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MauiMidiBirds.ViewModels;

public partial class LandingViewModel : ObservableObject
{

	[ObservableProperty] private string ?latestKey;

	public LandingViewModel()
	{
		LatestKey = "C";
	}

	[RelayCommand]
	void ReadKey()
	{
		LatestKey = "B";
	}
}

