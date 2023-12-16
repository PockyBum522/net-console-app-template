using Unique.Id.To.Be.Replaced.ApplicationLogistics;

namespace Unique.Id.To.Be.Replaced;

internal static class Program
{
    private static readonly ILogger Logger = LoggerSetup.ConfigureLogger()
            .MinimumLevel.Information()
            .CreateLogger(); 
    
    public static async Task Main()
    {
        Logger.Information("Starting!");
        
        Logger.Information("Exiting");
        
        // Make sure if we log on other threads right before the program ends, we can see it
        await Log.CloseAndFlushAsync();
        await Task.Delay(500);
    }
}
