using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PSITranscom;
using System.Reflection;

namespace Transcom
{
    public static class HostBuilder
    {
        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args)
                .ConfigureServices((_, services) =>
                    services.AddAutoMapper(Assembly.GetExecutingAssembly())
                    .AddTransient<Executor>()
                    .AddTransient<IFileReader, FileReader>());

        }
    }
}
