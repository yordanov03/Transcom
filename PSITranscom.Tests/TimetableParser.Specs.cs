using PSITranscom.Models;
using System.Collections.Generic;
using Transcom.Factories.ScheduleFactory;
using Transcom.Parsers;
using Xunit;

namespace PSITranscom.Tests
{
    public class TimetableParserSpecs
    {
        public string[] trainNumbers = new string[] { "0107" };
        public string[] timetableInput = new string[] { "0550001070970023472357" };

        [Fact]
        public void ParserParsesCorectlyInput()
        {
            //Arrange
            var timetableFactory = new TimetableFactory();
            var timetableParser = new TimetableParser(timetableFactory);

            //Act
            var parsedTimetables = timetableParser.ParseInput(timetableInput, trainNumbers);

            //Assert
            Assert.NotNull(parsedTimetables);
            Assert.IsType<List<Timetable>>(parsedTimetables);
            Assert.Equal("05500", parsedTimetables[0].SequenceNumber);
            Assert.Equal("0107", parsedTimetables[0].TrainNumber);
            Assert.Equal("09700", parsedTimetables[0].LocationCode);
            Assert.Equal("2347", parsedTimetables[0].ArrivalTime);
            Assert.Equal("2357", parsedTimetables[0].DepartureTime);
        }
    }
}
