using PSITranscom.Models;
using System.Collections.Generic;

namespace PSITranscom.Parsers
{
    public interface IScheduleParser
    {
        List<Schedule> ParseSchedule(string[] schedule);
    }
}
