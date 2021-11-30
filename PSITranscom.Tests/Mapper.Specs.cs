using AutoMapper;
using PSITranscom.Models;
using Transcom.Dtos;
using Transcom.Mapper;
using Xunit;

namespace Transcom.Tests
{
    public class MapperSpecs
    {

        [Fact]
        public void MapperShouldMapTrainScheduleDto()
        {
            ////Arrange
            var schedule = new Schedule("01012017", "0100", "31122017", "0106");
            var timeTable = new Timetable("2200", "0106", "1234", "0850", "0940");

            var config = new MapperConfiguration(cfg => cfg.AddProfile<MappingProfile>());
            var mapper = config.CreateMapper();

            ////Act
            ///
            var mappedTrainScheduleDto = mapper.Map<Schedule, TrainScheduleDto>(schedule);
            var mappedScheduledStop = mapper.Map<Timetable, ScheduledStopDto>(timeTable);

            //Assert
            Assert.Equal(schedule.TrainNumber, mappedTrainScheduleDto.TrainNumber);
            Assert.Equal(schedule.ValidFrom, mappedTrainScheduleDto.ValidFrom);
            Assert.Equal(schedule.ValidTo, mappedTrainScheduleDto.ValidTo);

            Assert.Equal(timeTable.ArrivalTime, mappedScheduledStop.ArrivalTime);
            Assert.Equal(timeTable.DepartureTime, mappedScheduledStop.DepartureTime);
            Assert.Equal(timeTable.LocationCode, mappedScheduledStop.LocationCode);
            Assert.Equal(timeTable.SequenceNumber, mappedScheduledStop.SequenceNumber);

            Assert.IsType<TrainScheduleDto>(mappedTrainScheduleDto);
            Assert.IsType<ScheduledStopDto>(mappedScheduledStop);
        }
    }
}
