using CommunityToolkit.Maui.Core;

namespace MauiApp2;

public partial class MainPage : ContentPage
{
    private readonly IPopupService _popupService;

    public MainPage(IPopupService popupService)
    {
        _popupService = popupService;
        InitializeComponent();
    }

    private void OnButtonClicked(object sender, EventArgs e)
    {
        _popupService.ShowPopup<MyPopupViewmodel>(viewmodel => viewmodel.Messages = new System.Collections.ObjectModel.ObservableCollection<string>(new[] { "Hello, World!" }));
    }
}

