using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Commons.Music.Midi;
using System.Diagnostics;

namespace MauiMidiBirds.ViewModels;

public partial class LandingViewModel : ObservableObject
{

	[ObservableProperty] private string ?latestKey;
	internal string controllerName = "APC Key 25";


    public LandingViewModel()
	{
		LatestKey = "C";

        
        var access = MidiAccessManager.Default;
		var inputs = access.Inputs;
		var deviceNumber = inputs.Where(i => i.Name == controllerName).FirstOrDefault();
		var input = access.OpenInputAsync(deviceNumber.Id).Result;
		input.MessageReceived += Input_MessageRecieved;
		
    }

    private void Input_MessageRecieved(object? sender, MidiReceivedEventArgs e)
    {
		Debug.WriteLine("Message Recieved");
		Debug.WriteLine($"{e.Data[0].ToString()} - {e.Data[1].ToString()} - {e.Data[2].ToString()}");
		LatestKey = e.Data[1].ToString();
    }
}

