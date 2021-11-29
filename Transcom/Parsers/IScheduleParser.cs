using PSITranscom.Models;
using System.Collections.Generic;

namespace Transcom.Parsers
{
    public interface IScheduleParser
    {
        List<Schedule> ParseSchedule(string[] schedule);
    }
}
