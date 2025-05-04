using CS.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

class Program
{
    static async Task Main(string[] args)
    {
        var services = new ServiceCollection()
            .AddLogging(cfg => {
                cfg.AddConsole();
                cfg.SetMinimumLevel(LogLevel.Information);
            })
            .AddSingleton<UserService>()
            .BuildServiceProvider();

        var logger = services.GetRequiredService<ILogger<Program>>();
        var userService = services.GetRequiredService<UserService>();

        logger.LogInformation("App started.");

        var user = await userService.GetUserAsync();
        Console.WriteLine($"User: {user.Name}, Age: {user.Age}");

        logger.LogInformation("App finished.");
    }
}