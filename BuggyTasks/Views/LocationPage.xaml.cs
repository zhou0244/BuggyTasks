using Microsoft.Maui.Controls;
using Microsoft.Maui.ApplicationModel;

namespace BuggyTasks.Views;

public partial class LocationPage : ContentPage
{
    public LocationPage()
    {
        InitializeComponent();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        GetLocation(); 
    }

    Task GetLocation()
    {
        var location =  Geolocation.GetLastKnownLocationAsync(); 
        if (location != null)
        {
            Console.WriteLine($"Lat: {location.Latitude}, Long: {location.Longitude}");
        }
    }
}