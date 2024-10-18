using BusinessLogic;
using BusinessLogic.Services;
using Microsoft.Extensions.Logging;
using BusinessLogic.Interfaces;
using Microsoft.Maui.Hosting;

namespace PokerAssistant
{
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

            builder.Services.AddSingleton<IGameService, GameService>();
            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddSingleton<Table4Players>();
            builder.Services.AddSingleton<Grid>();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
