using static Transcom.Constants.FileLocation;

namespace PSITranscom
{
    public static class FileReader
    {
        public static string[] ImportDailyRouteFromFile()
        {
            string[] lines = System.IO.File.ReadAllLines(DailyRouteFileLocationString);
            return lines;
        }
        public static string[] ImportScheduleFromFile()
        {
            string[] lines = System.IO.File.ReadAllLines(ScheduleFileLocationString);
            return lines;
        }

        public static string[] ImportTimetableFromFile()
        {
            string[] lines = System.IO.File.ReadAllLines(DailyRouteFileLocationString);
            return lines;
        }
    }
}
