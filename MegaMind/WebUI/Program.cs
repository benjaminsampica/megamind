using System;
using System.Net.Http;
using System.Threading.Tasks;
using MegaMind.Application;
using MegaMind.Persistence;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace MegaMind.WebUI
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddTransient(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddApplication();
            builder.Services.AddPersistence();

            await builder.Build().RunAsync();
        }
    }
}
