using Microsoft.Extensions.Logging;

namespace PassXYZ.Vault
{
    public static class MauiProgram
    {
        // NOTE: MauiApp instance - the entry point of your app
        public static MauiApp CreateMauiApp()
        {
            // NOTE: returns a MauiAppBuilder instance, which provides a .NET Generic Host interface
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("fa-regular-400.ttf", "FontAwesomeRegular");
                    fonts.AddFont("fa-solid-900.ttf", "FontAwesomeSolid");
                    fonts.AddFont("fa-brands-400.ttf","FontAwesomeBrands");
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    //fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
