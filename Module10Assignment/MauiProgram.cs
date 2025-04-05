using Microsoft.Extensions.Logging;
using Module10Assignment.ViewModels;
using Module10Assignment.Views;

namespace Module10Assignment;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

        builder.Services.AddSingleton<ContactsViewModel>();
        builder.Services.AddTransient<AddContactViewModel>();
        builder.Services.AddTransient<ContactDetailsViewModel>();

        builder.Services.AddSingleton<MainPage>();
        builder.Services.AddSingleton<ContactsPage>();
        builder.Services.AddTransient<ContactDetailsPage>();

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}