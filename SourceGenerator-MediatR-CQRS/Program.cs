using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace SourceGenerator_MediatR_CQRS
{
    public class Program
    {
        public record r1
        {
            public int Wheels { get; init; }
            public string Color { get; init; }
            public string Brand { get; init; }
        }
        
        public record r2
        {
            public int Wheels { get; init; }
            public string Color { get; init; }
            public string Brand { get; init; }
        }
        
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
            
        
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
