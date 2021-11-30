using Microsoft.Extensions.Options;
using PSITranscom.Exceptions;
using PSITranscom.Models;
using System.IO;
using static PSITranscom.Constants.ErrorMessages;

namespace PSITranscom
{
    public class FileReader : IFileReader
    {
        private readonly FileLocation _fileLocations;

        public FileReader(IOptions<FileLocation> options)
        {
            this._fileLocations = options.Value;
        }

        public FileData ImportFiles()
        {

            try
            {
                var fileData = new FileData
                {
                    DailyRouteData = File.ReadAllLines(_fileLocations.DailyRouteFileLocation),
                    ScheduleData = File.ReadAllLines(_fileLocations.ScheduleFileLocation),
                    TimetableData = File.ReadAllLines(_fileLocations.TimetableFileLocation)

                };

                return fileData;

            }
            catch
            {
                throw new ParserException($"{ParserErrorMessage}");
            }
        }
    }
}
