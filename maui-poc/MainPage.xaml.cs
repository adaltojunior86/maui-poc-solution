using maui_poc.Services;
using maui_poc.ViewModels;

namespace maui_poc;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
		BindingContext = new ResourceViewModel();
		Loader();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		CounterBtn.Text = count == 1 ? $"Clicked {count} time" : $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}

	private static async Task Loader()
	{
		await ResourceService.GetAllResources();
	}
	
}

