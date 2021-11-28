using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Transcom;
using Transcom.Exceptions;

namespace PSITranscom
{
    public class FileReader : IFileReader
    {
        //public static string[] ImportDailyRouteFromFile()
        //{
        //    string[] lines = System.IO.File.ReadAllLines(DailyRouteFileLocationString);
        //    return lines;
        //}
        //public static string[] ImportScheduleFromFile()
        //{
        //    string[] lines = System.IO.File.ReadAllLines(ScheduleFileLocationString);
        //    return lines;
        //}

        //public static string[] ImportTimetableFromFile()
        //{
        //    string[] lines = System.IO.File.ReadAllLines(DailyRouteFileLocationString);
        //    return lines;
        //}
        public string[] ImportFiles()
        {
            try
            {
                string[] dirs = Directory.GetFiles(@"../../../Source");
                return dirs;
            }
            catch (Exception e)
            {
                throw new ParserException("Could not parse file");
            }
        }
    }
}
