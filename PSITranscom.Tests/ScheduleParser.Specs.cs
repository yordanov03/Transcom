using PSITranscom.Models;
using System.Collections.Generic;
using PSITranscom.Factories.TimetableFactory;
using PSITranscom.Parsers;
using Xunit;

namespace PSITranscom.Tests
{
    public class ScheduleParserSpecs
    {
        private string[] scheduleInput = new string[] { "010120170100311220170106" };

        [Fact]
        public void ParserParsesCorectlyInput()
        {
            //Arrange
            var scheduleFactory = new ScheduleFactory();
            var scheduleParser = new ScheduleParser(scheduleFactory);

            //Act
            var parsedSchedule = scheduleParser.ParseSchedule(scheduleInput);

            //Assert
            Assert.NotNull(parsedSchedule);
            Assert.IsType<List<Schedule>>(parsedSchedule);
            Assert.Equal("01012017", parsedSchedule[0].ValidFrom);
            Assert.Equal("0100", parsedSchedule[0].RunningCode);
            Assert.Equal("31122017", parsedSchedule[0].ValidTo);
            Assert.Equal("0106", parsedSchedule[0].TrainNumber);
        }
    }
}
