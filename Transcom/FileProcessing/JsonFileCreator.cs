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
                var output = JsonConvert.SerializeObject(@$"../../../Output/{schedule.TrainNumber}.json", Formatting.Indented);

                using (StreamWriter file = File.CreateText(output))
                {
                    var serializer = new JsonSerializer();
                    //serialize object directly into file stream
                    serializer.Serialize(file, schedule);
                }
            }
            
        }
    }
}
