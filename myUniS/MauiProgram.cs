using Microsoft.Extensions.Logging;

namespace myUniS
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
                    fonts.AddFont("Poppins-Bold.ttf", "PoppinsBold");
                    fonts.AddFont("Poppins-ExtraBold.ttf", "PoppinsExtraBold");
                    fonts.AddFont("Poppins-SemiBold.ttf", "PoppinsSemiBold");
                    fonts.AddFont("Poppins-Medium.ttf", "PoppinsMedium");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();

        }


    }
}
