using System.Collections.Generic;
using System.IO;
using Transcom;
using Transcom.Exceptions;

namespace PSITranscom
{
    public class FileReader : IFileReader
    {
        private List<string[]> importedData = new List<string[]>();
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
        public List<string[]> ImportFiles()
        {
            try
            {
                string[] filePaths = Directory.GetFiles(@"../../../Source");
                foreach (var filePath in filePaths)
                {
                    var processedFile = File.ReadAllLines(filePath);
                    importedData.Add(processedFile);
                }
                return importedData;
            }
            catch
            {
                throw new ParserException("Could not parse file");
            }
        }
    }
}
