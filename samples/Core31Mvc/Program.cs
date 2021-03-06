using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Natasha.CSharp;

namespace Core31Mvc
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string result = NDelegate.RandomDomain().Func<string>("return \"a\";")();
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
