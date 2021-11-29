using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PSITranscom;
using PSITranscom.Models;
using System.Reflection;
using Transcom.Factories;
using Transcom.Factories.ScheduleFactory;
using Transcom.Factories.TimetableFactory;
using Transcom.Parsers;
using System;

namespace Transcom
{
    public static class HostBuilder
    {
        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args)
                .ConfigureServices((context, services) => {
                    services
                    .AddAutoMapper(Assembly.GetExecutingAssembly())
                    .AddTransient<Executor>()
                    .AddTransient<IFileReader, FileReader>()
                    .AddTransient<IScheduleParser, ScheduleParser>()
                    .AddTransient<IParser<DailyRoute>, DailyRouteParser<DailyRoute>>()
                    .AddTransient<IParser<Timetable>, TimetableParser<Timetable>>()
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
