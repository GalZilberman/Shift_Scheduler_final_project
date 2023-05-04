using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftScheduler
{
    internal class Shift
    {
        int shiftId;
        Day startShiftDayArrow;
        TimeSpan startShiftTime;
        Day endShiftDayArrow;
        TimeSpan endShiftTime;
        WorkerType workerTypeNeededArrow;
        int workerAmountNedded;
        Worker[] shiftWorkersForTheCurrentWeekArrow;
        Worker[] shiftWorkersForTheNextWeekArrow;
        int workersAmountAlreadyAssignedForNextWeek = 0;
        bool isActiveShift;

        static int counterShift = 0;
        static int numberToAssignToShiftId = 1;

        
        public Shift(Day paramStartShiftDayArrow, TimeSpan paramStartShiftTime, Day paramEndShiftDayArrow, TimeSpan paramEndShiftTime, WorkerType paramWorkerTypeNeededArrow, int paramWorkerAmountNedded, bool paramIsActiveShift = true)
        {
            SetShiftId();
            SetStartShiftDayArrow(paramStartShiftDayArrow);
            SetStartShiftTime(paramStartShiftTime); 
            SetEndShiftDayArrow(paramEndShiftDayArrow);
            SetEndShiftTime(paramEndShiftTime);
            SetWorkerTypeNeededArrow(paramWorkerTypeNeededArrow);
            SetWorkerAmountNedded(paramWorkerAmountNedded);
            shiftWorkersForTheCurrentWeekArrow = new Worker[25];
            shiftWorkersForTheNextWeekArrow = new Worker[25];
            SetIsActiveShift(paramIsActiveShift);
            counterShift++;
        }

        public Shift(Shift paramShift) :this(paramShift.startShiftDayArrow, paramShift.startShiftTime ,paramShift.endShiftDayArrow, paramShift.endShiftTime, paramShift.workerTypeNeededArrow, paramShift.workerAmountNedded) { }


        public int GetShiftId() { return shiftId; }
        
        public Day GetStartShiftDayArrow() {  return startShiftDayArrow; }
        
        public TimeSpan GetStartShiftTime() {  return startShiftTime; }
        
        public Day GetEndShiftDayArrow() { return endShiftDayArrow; }
        
        public TimeSpan GetEndShiftTime() { return endShiftTime; }
        
        public WorkerType GetWorkerTypeNeededArrow() {  return workerTypeNeededArrow; }
        
        public int GetWorkerAmountNedded() {  return workerAmountNedded; }

        public bool GetIsActiveShift() { return isActiveShift; }

        public int GetWorkersAmountAlreadyAssignedForNextWeek() { return workersAmountAlreadyAssignedForNextWeek; }

        public Worker[] GetShiftWorkersForTheCurrentWeekArrow() { return shiftWorkersForTheCurrentWeekArrow; }

        public Worker[] GetshiftWorkersForTheNextWeekArrow() { return shiftWorkersForTheNextWeekArrow; } 

        public static int GetCounterShift() { return counterShift; }


        public void SetShiftId() { shiftId = numberToAssignToShiftId++; }
        
        public void SetStartShiftDayArrow(Day paramStartShiftDayArrow) { startShiftDayArrow = paramStartShiftDayArrow; }
        
        public void SetStartShiftTime(TimeSpan paramStartShiftTime) { startShiftTime = paramStartShiftTime; }
        
        public void SetEndShiftDayArrow(Day paramEndShiftDayArrow) { endShiftDayArrow = paramEndShiftDayArrow; }
        
        public void SetEndShiftTime(TimeSpan paramEndShiftTime) {  endShiftTime = paramEndShiftTime; }
        
        public void SetWorkerTypeNeededArrow(WorkerType paramWorkerTypeNeededArrow) { workerTypeNeededArrow = paramWorkerTypeNeededArrow; }
        
        public void SetWorkerAmountNedded(int paramWorkerAmountNedded) { workerAmountNedded = paramWorkerAmountNedded; }

        public void SetIsActiveShift(bool paramIsActiveShift) { isActiveShift = paramIsActiveShift; }


        public void AddWorkerToShiftWorkersForTheNextWeekArrow(Worker paramWorker)
        {
            for (int i = 0; i < shiftWorkersForTheNextWeekArrow.Length; i++)
            {
                if (shiftWorkersForTheNextWeekArrow[i] == null)
                {
                    shiftWorkersForTheNextWeekArrow[i] = paramWorker;
                    workersAmountAlreadyAssignedForNextWeek++;
                    return;
                }
            }
        }


        public void ResetShiftWorkersForTheNextWeekArrow()
        {
            for (int i = 0; i < shiftWorkersForTheNextWeekArrow.Length; i++)
            {
                shiftWorkersForTheNextWeekArrow[i] = null;
                workersAmountAlreadyAssignedForNextWeek = 0;
            }
        }


        // אצטרך לעשות את זה מהתוכנית הראשית או ממחלקת מקום עבודה
        //public void UpdateShift(int paramShiftIdToUpdate)
        //{
        //    Console.WriteLine("The current shift is:");
        //    Console.WriteLine($"Start shift day: {startShiftDayArrow}");
        //    Console.WriteLine($"Start shift time: {startShiftTime}");
        //    Console.WriteLine($"End shift day: {endShiftDayArrow}");
        //    Console.WriteLine($"End shift time: {endShiftTime}");
        //    Console.WriteLine($"Worker type: {workerTypeNeededArrow}");
        //    Console.WriteLine($"Worker needed amount: {workerAmountNedded}");
        //    Console.WriteLine("What would you like to change?\n1. Start shift day\n2. Start shift time\n3. End shift day\n4. End shift time:\n5. Worker type nedded\n6. Worker amount needed");
        //    int choice = int.Parse(Console.ReadLine());
        //    switch (choice)
        //    {
        //        //case 1:
        //        //    Console.WriteLine($"What is the new start shift day?\n");
        //    }
        //}
        

        // כאן כנראה אצטרך לעשות מתודה שמעדכנת את העובדים במשמרת


        public void CopyShiftWorkersForTheNextWeekArrowToshiftWorkersForTheCurrentWeekArrow()
        {
            for (int i = 0; i < shiftWorkersForTheCurrentWeekArrow.Length; i++)
            {
                shiftWorkersForTheCurrentWeekArrow[i] = shiftWorkersForTheNextWeekArrow[i];               
            }
        }


        public override string ToString()
        {
            string st = $"Shift ID: {shiftId} | Start shift day: {startShiftDayArrow.GetDayName()} | Start shift time: {startShiftTime} | End shift day: {endShiftDayArrow.GetDayName()} | End shift time: {endShiftTime} | Worker type needed: {workerTypeNeededArrow} | Worker amount needed? {workerAmountNedded}";
            return st;
        }

    }
}
