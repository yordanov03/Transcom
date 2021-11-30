using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using PSITranscom.Dtos;
using static PSITranscom.Constants.FilePath;

namespace PSITranscom
{
    public class JsonFileCreator : IJsonFileCreator
    {
        public void CreateJsonFile(List<TrainScheduleDto> schedulePerTrain)
        {

            foreach (var schedule in schedulePerTrain)
            {
                var path = $"{OutputFileLocation}{schedule.TrainNumber}.json";

                using (StreamWriter file = File.CreateText(path))
                {
                    var serializer = new JsonSerializer();

                    //data is structured in multipule lines
                    serializer.Formatting = Formatting.Indented;

                    //serialize object directly into file stream
                    serializer.Serialize(file, schedule);
                }
            }

        }
    }
}
