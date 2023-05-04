using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftScheduler
{
    internal class WorkerType
    {
        int workerTypeId;
        string workerTypeDetails;

        static int counterWorkerType = 0;
        static int numberToAssignToWorkerTypeId = 1;


        public WorkerType (string paramWorkerTypeDetails)
        {
            SetWorkerTypeId();
            SetWorkerTypeDetails(paramWorkerTypeDetails);
            counterWorkerType++;
        }

        public WorkerType(WorkerType paramWorkerType) :this(paramWorkerType.workerTypeDetails) { }


        public int GetWorkerTypeId() { return workerTypeId; }
        
        public string GetWorkerTypeDetails() { return workerTypeDetails; }

        public static int GetCounterWorkerType() { return counterWorkerType; } 


        public void SetWorkerTypeId() { workerTypeId = numberToAssignToWorkerTypeId++; }
        
        public void SetWorkerTypeDetails (string paramWorkerTypeDetails) {  workerTypeDetails = paramWorkerTypeDetails; }


        public override string ToString()
        {
            string st = $"{workerTypeId}: {workerTypeDetails}";
            return st;
        }
    }
}
