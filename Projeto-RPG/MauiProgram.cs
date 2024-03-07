using Microsoft.Extensions.Logging;

namespace Projeto_RPG;

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
				fonts.AddFont("Cocaine-sans.ttf", "Cocaine");
				fonts.AddFont("Chp-fire.ttf", "Chp-Fire");
				fonts.AddFont("Base-dois.ttf", "Base");
				fonts.AddFont("Anywhere.ttf", "Anywhere");
				fonts.AddFont("Anglo-text.ttf", "Anglo");
				fonts.AddFont("A-theme-for-murder.ttf", "Theme-for-murder");
				fonts.AddFont("Gimme-Danger.ttf", "Gimme-danger");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
