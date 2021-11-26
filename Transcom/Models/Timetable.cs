﻿using System;

namespace PSITranscom.Models
{
    public class TimeTable
    {
        public TimeTable(
            string validFrom,
            string runningCode,
            string validTo,
            string trainNumber)
        {
            this.ValidFrom = validFrom;
            this.RunningCode = runningCode;
            this.ValidTo = validTo;
            this.TrainNumber = trainNumber;
        }

        public string ValidFrom { get; set; }
        public string RunningCode { get; set; }
        public string ValidTo { get; set; }
        public string TrainNumber { get; set; }
    }
}
