using Microsoft.Extensions.Configuration;

namespace UdemyEfCore.CodeFirst;

// Initializer class
public class Initializer
{
    public static IConfigurationRoot Configuration;
    
    // Build metod
    // appsettings.json dosyasındaki gerekli key value tiplerini okumak için. Mesela Db yolunu
    public static void Build()
    {
        var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
        Configuration = builder.Build();
    }
}