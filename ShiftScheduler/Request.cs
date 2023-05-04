using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftScheduler
{
    internal class Request
    {
        int requestId;
        string requestDetails;
        // להוסיף יום
        // לשקול להוסיף יום תחילת בקשה ויום סגירת בקשה וגם להוסיף את זה למסד נתונים ששם יש רק יום אחד לבחירה
        TimeSpan startTime;
        TimeSpan endTime;

        static int counterRequest;
        static int numberToAssignToRequestId = 1;


        public Request(string paramRequestDetails, TimeSpan paramStartTime, TimeSpan paramEndTime)
        {
            SetRequestId();
            SetRequestDetails(paramRequestDetails);
            SetStartTime(paramStartTime);
            SetEndTime(paramEndTime);
            counterRequest++;
        }

        public Request(Request paramRequest) :this(paramRequest.requestDetails, paramRequest.startTime, paramRequest.endTime) { }
       

        public int GetRequestId() { return requestId; }
        
        public string GetRequestDetails() {  return requestDetails; }
        
        public TimeSpan GetStartTime() { return startTime; }
        
        public TimeSpan GetEndTime() { return endTime; }

        public static int GetCounterRequest() { return counterRequest; }

       
        public void SetRequestId() { requestId = numberToAssignToRequestId++; }
        
        public void SetRequestDetails(string paramRequestDetails) { requestDetails = paramRequestDetails; }

        public void SetStartTime(TimeSpan paramStartTime) { startTime = paramStartTime; }

        public void SetEndTime(TimeSpan paramEndTime) { endTime = paramEndTime; }


        public override string ToString()
        {
            string st = $"Request ID: {requestId}\nDetails: {requestDetails}\nTime cannot work: {startTime} - {endTime}";
            return st;
        }
    }
}
