namespace MauiApp4;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();

        twoPaneView.Pane1Length = new GridLength(4, GridUnitType.Star);
        twoPaneView.Pane2Length = new GridLength(1, GridUnitType.Star);
    }

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
}

