using System;

namespace PSITranscom.Models
{
    public class FileLocation
    {
        public const string FilesLocation = "FilesLocation";

        public string DailyRouteFileLocation { get; set; } = String.Empty;
        public string ScheduleFileLocation { get; set; } = String.Empty;
        public string TimetableFileLocation { get; set; } = String.Empty;

    }
}
