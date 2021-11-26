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
                using (StreamWriter file = File.CreateText(@$"C:\Users\sveto\source\repos\Transcom\Transcom\Output\{schedule.TrainNumber}.json"))
                {
                    var serializer = new JsonSerializer();
                    //serialize object directly into file stream
                    serializer.Serialize(file, schedule);
                }
            }
            
        }
    }
}
