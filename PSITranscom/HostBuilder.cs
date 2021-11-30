using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PSITranscom.Factories;
using PSITranscom.Factories.ScheduleFactory;
using PSITranscom.Factories.TimetableFactory;
using PSITranscom.Models;
using PSITranscom.Parsers;
using System.Reflection;

namespace PSITranscom
{
    public static class HostBuilder
    {
        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args)
                .ConfigureServices((context, services) =>
                {
                    services
                    .AddAutoMapper(Assembly.GetExecutingAssembly())
                    .AddTransient<Executor>()
                    .AddTransient<IFileReader, FileReader>()
                    .AddTransient<IScheduleParser, ScheduleParser>()
                    .AddTransient<IParser<DailyRoute>, DailyRouteParser>()
                    .AddTransient<IParser<Timetable>, TimetableParser>()
                    .AddTransient<IDailyRouteFactory, DailyRouteFactory>()
                    .AddTransient<IScheduleFactory, ScheduleFactory>()
                    .AddTransient<ITimetableFactory, TimetableFactory>()
                    .AddTransient<ITrainScheduleBuilder, TrainScheduleBuilder>()
                    .AddTransient<IJsonFileCreator, JsonFileCreator>();
                    services.Configure<FileLocation>(
                       context.Configuration.GetSection(FileLocation.FilesLocation));
                });

        }

    }
}
