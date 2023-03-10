//using Bumptech.Glide.Load.Resource.Bitmap;
using CRUD_mob_app.ViewModels;

namespace CRUD_mob_app;

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

		builder.Services.AddSingleton<IConnectivity>(Connectivity.Current);

		builder.Services.AddSingleton<Car>();
		builder.Services.AddSingleton<CarViewModel>();

		builder.Services.AddTransient<DetailPage>();
		builder.Services.AddTransient<DetailViewModel>();


        return builder.Build();
	}
}
