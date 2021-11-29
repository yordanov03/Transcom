using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PSITranscom;
using PSITranscom.Models;
using System.Reflection;
using Transcom.Factories;
using Transcom.Parsers;

namespace Transcom
{
    public static class HostBuilder
    {
        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args)
                .ConfigureServices((_, services) =>
                    services
                    .AddAutoMapper(Assembly.GetExecutingAssembly())
                    .AddTransient<Executor>()
                    .AddTransient<IFileReader, FileReader>()
                    .AddTransient<IScheduleParser, ScheduleParser>()
                    .AddTransient<IParser<DailyRoute>, DailyRouteParser<DailyRoute>>()
                    .AddTransient<IParser<Timetable>, TimetableParser<Timetable>>());

        }
    }
}
