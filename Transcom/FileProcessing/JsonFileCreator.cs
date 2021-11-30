using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using Transcom.Dtos;

namespace Transcom
{
    public class JsonFileCreator : IJsonFileCreator
    {
        public void CreateJsonFile(List<TrainScheduleDto> schedulePerTrain)
        {

            foreach (var schedule in schedulePerTrain)
            {
                var path = @$"..\..\..\Output\{schedule.TrainNumber}.json";

                using (StreamWriter file = File.CreateText(path))
                {
                    var serializer = new JsonSerializer();
                    serializer.Formatting = Formatting.Indented;
                    //serialize object directly into file stream
                    serializer.Serialize(file, schedule);
                }
            }

        }
    }
}
