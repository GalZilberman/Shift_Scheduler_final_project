using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftScheduler
{
    internal class Worker : User
    {
        WorkerType workerTypeArrow;      
        DateTime startWorkingDate;
        int maxRequestsAmount;
        int requestsUsedAmount;
        Request[] previousWeekRequestsArrow;
        Request[] requests;
        int maxShiftForAssignmentPerWeek;
        int shiftsAmountAlreadyAssignedForNextWeek;
        bool isActiveWorker;
        Shift[] currentWeekShifts;
        Shift[] nextWeekShifts;
        string specialMessage;
        Day[] daysCannotWorkArrow;

        static int counterWorker = 0;


        public Worker(string paramEmail, string paramPassword, string paramFirstName, string paramLastName, bool paramIsVerifiedEmail, WorkerType paramWorkerTypeArrow, DateTime paramStartWorkingDate, int paramMaxRequestsAmount = 2, int paramRequestsUsedAmount = 0, int paramMmaxShiftForAssignmentPerWeek = 5, int paramShiftsAmountAlreadyAssignedForNextWeek = 0, bool paramIsActiveWorker = true, string paramSpecialMessage = "") :base(paramEmail, paramPassword, paramFirstName, paramLastName, paramIsVerifiedEmail)
        {
            SetWorkerTypeArrow(paramWorkerTypeArrow);
            SetStartWorkingDate(paramStartWorkingDate);
            SetMaxRequestsAmount(paramMaxRequestsAmount);
            SetRequestsUsedAmount(paramRequestsUsedAmount);
            SetMaxShiftForAssignmentPerWeek(paramMmaxShiftForAssignmentPerWeek);
            SetShiftsAmountAlreadyAssignedForNextWeek(paramShiftsAmountAlreadyAssignedForNextWeek);
            SetIsActiveWorker(paramIsActiveWorker);
            previousWeekRequestsArrow = new Request[7];
            requests = new Request[7];
            currentWeekShifts = new Shift[14];
            nextWeekShifts = new Shift[14];
            daysCannotWorkArrow = new Day[7];
            SetSpecialMessage(paramSpecialMessage);
            counterWorker++;
        }


        public Worker(Worker paramWorker) : this(paramWorker.email, paramWorker.password, paramWorker.firstName, paramWorker.lastName, paramWorker.isVerifiedEmail, paramWorker.workerTypeArrow, paramWorker.startWorkingDate) { }


        public WorkerType GetWorkerTypeArrow() { return workerTypeArrow; }

        public DateTime GetStartWorkingDate() { return startWorkingDate; }

        public int GetMaxRequestsAmount() {  return maxRequestsAmount; }
        
        public int GetRequestsUsedAmount() {  return requestsUsedAmount; }

        public Request[] GetRequests() { return requests; }

        public int GetMaxShiftForAssignmentPerWeek() { return maxShiftForAssignmentPerWeek; }
        
        public int GetShiftsAmountAlreadyAssignedForNextWeek() { return shiftsAmountAlreadyAssignedForNextWeek; }
        
        public bool GetIsActiveWorker() { return isActiveWorker; }

        public string GetSpecialMessage() { return specialMessage; }

        public Shift[] GetCurrentWeekShifts() { return currentWeekShifts; }

        public Shift[] GetNextWeekShifts() { return nextWeekShifts; }


        public Day[] GetdaysCannotWorkArrow() { return daysCannotWorkArrow; }

        public static int GetCounterWorker() { return counterWorker; }


        public void SetWorkerTypeArrow(WorkerType paramWorkerTypeArrow) { workerTypeArrow = paramWorkerTypeArrow; }

        public void SetStartWorkingDate(DateTime paramDate) { startWorkingDate = paramDate; }

        public void SetMaxRequestsAmount(int paramMaxRequestsAmount) { maxRequestsAmount = paramMaxRequestsAmount; }

        public void SetRequestsUsedAmount(int paramRequestsUsedAmount) { requestsUsedAmount = paramRequestsUsedAmount; }
        
        public void SetMaxShiftForAssignmentPerWeek(int paramMaxShiftForAssignmentPerWeek) { maxShiftForAssignmentPerWeek = paramMaxShiftForAssignmentPerWeek; }

        public void SetShiftsAmountAlreadyAssignedForNextWeek(int paramShiftsAmountAlreadyAssignedForNextWeek) { shiftsAmountAlreadyAssignedForNextWeek = paramShiftsAmountAlreadyAssignedForNextWeek; }

        public void SetIsActiveWorker(bool paramIsActiveWorker) { isActiveWorker = paramIsActiveWorker; }
        
        public void SetSpecialMessage(string paramSpecialMessage) {  specialMessage = paramSpecialMessage; }


        public void AddRequestToRequests(Request paramRequest)
        {
            if (requestsUsedAmount >= maxRequestsAmount)
            {
                Console.WriteLine("No more requests allowed");
                return;
            }
            for (int i = 0; i < requests.Length; i++)
            {
                if (requests[i] == null)
                {
                    requests[i] = paramRequest;
                    requestsUsedAmount++;
                    return;
                }
            }
        }


        public void RemoveRequestFromRequests(int paramRequestIdToRemove)
        {
            for (int i = 0; i < requests.Length; i++)
            {
                if (requests[i].GetRequestId() == paramRequestIdToRemove)
                {
                    requests[i] = null;
                    requestsUsedAmount--;
                    return;
                }
            }
        }


        public void ResetRequests()
        {
            for (int i = 0; i < requests.Length; i++)
            {
                requests[i] = null;
            }
            requestsUsedAmount = 0;
        }


        public void CopyRequestsToPreviousWeekRequestsArrow()
        {
            for (int i = 0; i < requests.Length; i++)
            {
                if (requests[i] != null)
                {
                    previousWeekRequestsArrow[i] = requests[i];
                }
            }
        }


        public void ResetPreviousWeekRequestsArrow()
        {
            for (int i = 0; i < previousWeekRequestsArrow.Length; i++)
            {
                previousWeekRequestsArrow[i] = null;
            }        
        }


        public void AddDayToDaysCannotWorkArrow(Day paramDayToAddArrow)
        {
            daysCannotWorkArrow[paramDayToAddArrow.GetDayId() - 1] = paramDayToAddArrow; 
        }


        public void RemoveDaysFromCannotWorkArrow(Day paramDayToAddArrow)
        {
            daysCannotWorkArrow[paramDayToAddArrow.GetDayId() - 1] = null;
        }


        public void AddShiftToNextWeekShifts(Shift paramShift)
        {          
            for (int i = 0; i < nextWeekShifts.Length; i++)
            {
                if (nextWeekShifts[i] == null)
                {
                    nextWeekShifts[i] =  new Shift(paramShift);
                    shiftsAmountAlreadyAssignedForNextWeek++;
                    return;
                }
            }
        }


        public void ResetShiftToNextWeekShifts()
        {
            for (int i = 0; i < nextWeekShifts.Length; i++)
            {
                nextWeekShifts[i] = null;
            }
            shiftsAmountAlreadyAssignedForNextWeek = 0;
        }


        public void CopyeNxtWeekShiftsArrowToCurrentWeekShiftsArrow()
        {
            for (int i = 0; i < nextWeekShifts.Length; i++)
            {
                if (nextWeekShifts[i] == null)
                {
                    return;
                }
                currentWeekShifts[i] = nextWeekShifts[i];
            }
        }


        public override string ToString()
        {
            string st = "";
            return st;
        }
    }
}
