using System.Diagnostics;
using Commons.Music.Midi;
using CommunityToolkit.Maui.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using MauiMidiBirds.Services;
using Microsoft.Maui.Dispatching;

namespace MauiMidiBirds.ViewModels;

public partial class BaseViewModel : ObservableObject
{
    internal string controllerName = "APC Key 25";
    [ObservableProperty] private string? latestKey;
    [ObservableProperty] public MediaSource? birdSong;
    [ObservableProperty] public bool connected;
    [ObservableProperty] public string? latestBird;
    [ObservableProperty] public string? latestBirdImage;

    public BaseViewModel()
	{
        Debug.WriteLine($"{Data.Birds.Count} birds in the database");
        LatestKey = "0";
        ConnectToMidi();
    }

    public void ConnectToMidi()
    {
        var access = MidiAccessManager.Default;
        var inputs = access.Inputs;
        var deviceNumber = inputs.Where(i => i.Name == controllerName).FirstOrDefault();
        if (deviceNumber != null)
        {
            var input = access.OpenInputAsync(deviceNumber.Id).Result;
            Debug.WriteLine($"Connected to {controllerName} Midi Controller");
            input.MessageReceived += Input_MessageRecieved;
            Connected = true;
        } else
        {
            Connected = false;
        }
    }

    private void Input_MessageRecieved(object? sender, MidiReceivedEventArgs e)
    {
        Debug.WriteLine("Message Recieved");
        Debug.WriteLine($"{e.Data[0].ToString()} - {e.Data[1].ToString()} - {e.Data[2].ToString()}");
        LatestKey = e.Data[1].ToString();

        if (e.Data[2] > 0)
        {
            var bird = Data.Birds.Where(b => b.Id == e.Data[1]).FirstOrDefault();
            LatestBird = bird?.CommonName;

            LatestBirdImage = bird?.Image;
            

            if (Shell.Current is AppShell shell){
                MediaElement player = shell.GetPlayer();

                player.Dispatcher.Dispatch(() =>
                {
                    player.Source = MediaSource.FromResource(bird?.Song);
                });             
            }
        }
    }
}
