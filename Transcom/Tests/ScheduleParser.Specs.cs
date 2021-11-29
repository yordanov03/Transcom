using PSITranscom.Models;
using System.Collections.Generic;
using Transcom.Factories.TimetableFactory;
using Transcom.Parsers;
using Xunit;

namespace Transcom.Tests
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
            Assert.Equal("0100", parsedSchedule[1].RunningCode);
            Assert.Equal("31122017", parsedSchedule[2].ValidTo);
            Assert.Equal("0106", parsedSchedule[2].TrainNumber);
        }
    }
}
