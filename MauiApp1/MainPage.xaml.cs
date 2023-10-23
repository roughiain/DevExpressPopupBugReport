namespace MauiApp1;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        System.Diagnostics.Debug.WriteLine($"PopUp.IsOpen : {Popup.IsOpen}");
        DebugLabel.Text = $"PopUp.IsOpen : {Popup.IsOpen}";
    }
}
