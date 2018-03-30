using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace ClientInventory.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseKestrel()
                .UseUrls("http://*:6060")
                .UseStartup<Startup>()
                .Build();
    }
}
