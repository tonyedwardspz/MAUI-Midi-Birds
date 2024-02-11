namespace MauiMidiBirds.Models;

public class Bird
{
    public int Id {get; set;}
    public string CommonName {get; set;}
    public string ImageCredit {get; set;}
    public string SongCredit {get; set;}
    public int Sightings {get; set;}
    public string Image
    {
        get
        {
            return CommonName.ToLower().Replace(" ", "-") + ".png";
        }
    }
    public string Song
    {
        get
        {
            return CommonName.ToLower().Replace(" ", "-") + ".mp3";
        }
    }
}
