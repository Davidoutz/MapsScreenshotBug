namespace MapsScreenshotBug;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        IScreenshotResult screen = await map.CaptureAsync();
        Stream stream = await screen.OpenReadAsync();
        var image = ImageSource.FromStream(() => stream);
        screenshot.Source = image;
    }
}

