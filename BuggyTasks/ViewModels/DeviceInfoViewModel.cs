using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.Maui.Devices;

namespace BuggyTasks.ViewModels;

public partial class DeviceInfoViewModel : ObservableObject
{
    [ObservableProperty]
    string model = DeviceInfo.Model;

    [ObservableProperty]
    string platform = DeviceInfo.Platform.ToString();
}