using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftScheduler
{
    internal class Day
    {
        int dayId;
        string dayName;

        static int counterDay = 0;
        static int numberToAssignToDayId = 1;

 
        public Day(string paramDayName)
        {
            SetDayId();
            SetDayName(paramDayName);
            counterDay++;           
        }

        public Day(Day paramDay) :this(paramDay.dayName){ }


        public void SetDayId() { dayId = numberToAssignToDayId++; }
        
        public void SetDayName(string paramDayName) {  dayName = paramDayName; }
        
        
        public int GetDayId() {  return dayId; }
        
        public string GetDayName() {  return dayName; }

        public static int GetCounterDay() { return counterDay; }


        public override string ToString()
        {
            string st = $"{dayId}: {dayName}";
            return st;
        }
    }
}
