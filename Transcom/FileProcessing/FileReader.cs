using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using PSITranscom.Models;
using System.Collections.Generic;
using System.IO;
using Transcom;
using Transcom.Exceptions;

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
                throw new ParserException("Could not parse file");
            }
        }
    }
}
