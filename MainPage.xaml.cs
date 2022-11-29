namespace Borbola_Anamaria_Lab7;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"S-au plantat {count} copaci";
		else
			CounterBtn.Text = $"S-au plantat {count} copaci";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
}

