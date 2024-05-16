using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;

namespace MauiApp2;
public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiCommunityToolkit()
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

#if DEBUG
		builder.Logging.AddDebug();
#endif
        builder.Services
            .AddSingleton<MainPage>()
            .AddTransientPopup<MyPopup, MyPopupViewmodel>();
        return builder.Build();
    }
}
