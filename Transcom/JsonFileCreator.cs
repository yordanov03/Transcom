using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using Transcom.Dtos;

namespace Transcom
{
    public class JsonFileCreator
    {
        public void CreateJsonFile(List<TrainScheduleDto> schedulePerTrain)
        {

            foreach (var schedule in schedulePerTrain)
            {
                var x = JsonConvert.SerializeObject(@$"C:\Users\sveto\source\repos\Transcom\Transcom\Output\{schedule.TrainNumber}.json", Formatting.Indented);

                using (StreamWriter file = File.CreateText(x))
                {
                    var serializer = new JsonSerializer();
                    //serialize object directly into file stream
                    serializer.Serialize(file, schedule);
                }
            }
            
        }
    }
}
