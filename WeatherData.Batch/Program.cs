using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace WeatherData.Batch;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        IHostBuilder hostBuilder = Host.CreateDefaultBuilder();
        hostBuilder.ConfigureServices((context,services) =>
        {
            services.AddSingleton<Application>();
        });
        IHost host = hostBuilder.UseConsoleLifetime().Build();
        Application app = host.Services.GetRequiredService<Application>();
        app.Run();
    }
}



