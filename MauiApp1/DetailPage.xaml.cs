using MauiApp1.ViewModel;

namespace MauiApp1;

public partial class DetailPage : ContentPage
{
	public DetailPage(DetailVievModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}