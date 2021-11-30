using System.Collections.Generic;
using PSITranscom.Dtos;

namespace PSITranscom
{
    public interface IJsonFileCreator
    {
        void CreateJsonFile(List<TrainScheduleDto> schedulePerTrain);
    }
}
