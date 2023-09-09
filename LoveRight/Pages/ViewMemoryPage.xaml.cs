using LoveRight.Models;
using LoveRight.ViewModel;

namespace LoveRight.Pages;

public partial class ViewMemoryPage : ContentPage
{
	MemoryViewModel viewModel;
	public ViewMemoryPage()
	{
		BindingContext = viewModel = new MemoryViewModel();

		InitializeComponent();
	}

    protected override void OnAppearing()
    {
		viewModel.OnPropertyChanged("Memories");
    }

    private void AddMemoryButton_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new MemoryPage(new MemoryModel()
		{
			Date="01/01/2001",
			Description =""
		}));
    }

    private void MemorySelectListView_ItemTapped(object sender, ItemTappedEventArgs e)
    {
		MemoryModel tapped = (MemoryModel)e.Item;
		Navigation.PushAsync(new MemoryPage(tapped));
    }
}