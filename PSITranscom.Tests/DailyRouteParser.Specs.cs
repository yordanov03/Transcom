using PSITranscom.Models;
using System.Collections.Generic;
using Transcom.Factories;
using Transcom.Parsers;
using Xunit;

namespace Transcom.Tests
{
    public class DailyRouteParserSpecs
    {
        private string[] dailyRouteInput = new string[] { "010015012017" };
        private string[] parsedRunningCode = new string[] { "0100" };

        [Fact]
        public void ParserParsesCorectlyInput()
        {
            //Arrange
            var dailyRouteFactory = new DailyRouteFactory();
            var dailyRouteParser = new DailyRouteParser(dailyRouteFactory);


            //Act
            var parsedDailyRoute = dailyRouteParser.ParseInput(dailyRouteInput, parsedRunningCode);

            //Assert
            Assert.NotNull(parsedDailyRoute);
            Assert.IsType<List<DailyRoute>>(parsedDailyRoute);
            Assert.Equal("0100", parsedDailyRoute[0].RunningDayCode);
            Assert.Equal("15012017", parsedDailyRoute[0].RunningDate);
        }
    }
}
