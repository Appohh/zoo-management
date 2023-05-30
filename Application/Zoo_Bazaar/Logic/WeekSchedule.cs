﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicCL
{
    public class WeekSchedule
    {
        public DateTime Monday { get; set; }

        public DateTime Sunday { get; set; }

        public int Week { get; set; }

        public WeekSchedule(DateTime date)
        {
            Monday = new GregorianCalendar().AddDays(date, -((int)date.DayOfWeek) + 1).Date.Add(new TimeSpan(0, 0, 0));
            Sunday = Monday.AddDays(6).Date.Add(new TimeSpan(23, 59, 59));
            Week = CalculateWeekNumber(date);
        }

        private int CalculateWeekNumber(DateTime date)
        {
            var thursday = date.AddDays(3 - ((int)date.DayOfWeek + 6) % 7);
            return 1 + (thursday.DayOfYear - 1) / 7;
        }

    }
}
