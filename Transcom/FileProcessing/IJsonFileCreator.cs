using System.Collections.Generic;
using Transcom.Dtos;

namespace Transcom
{
    public interface IJsonFileCreator
    {
        void CreateJsonFile(List<TrainScheduleDto> schedulePerTrain);
    }
}
