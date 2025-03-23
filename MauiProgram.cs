using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Hosting;
using System.Net.Http;
using ISAControlesAPP.Repositories;

namespace ISAControlesAPP
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();

            builder
                .UseMauiApp<App>()  // Usamos la clase App que hereda de Application
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            // Registra HttpClient y Repositorios
            builder.Services.AddSingleton<HttpClient>();
            builder.Services.AddSingleton<IUserRepository, UserRepository>();

            return builder.Build(); // Construye la aplicación MAUI
        }
    }
}






























