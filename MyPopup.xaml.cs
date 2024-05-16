using CommunityToolkit.Maui.Views;

namespace MauiApp2;

public partial class MyPopup : Popup
{
	public MyPopup(MyPopupViewmodel viewmodel)
	{
		BindingContext = viewmodel;
		InitializeComponent();
	}
}