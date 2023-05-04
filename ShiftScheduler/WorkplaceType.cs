using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftScheduler
{
    internal class WorkplaceType
    {
        int workplaceTypeId;
        string workplaceTypeDetails;
        WorkerType[] workerTypes;
        
        static int counterWorkplaceType = 0;
        static int numberToAssaignToWorkplaceTypeId = 1;


        public WorkplaceType(string paramWorkplaceTypeDetails)
        {
            SetWorkplaceTypeId();
            SetWorkplaceTypeDetails(paramWorkplaceTypeDetails);
            workerTypes = new WorkerType[15];
            counterWorkplaceType++;
        }

        public WorkplaceType(WorkplaceType paramWorkplaceType) :this(paramWorkplaceType.workplaceTypeDetails) { }


        public int GetWorkplaceTypeId() { return workplaceTypeId; }
        
        public string GetWorkplaceTypeDetails() {  return workplaceTypeDetails; }

        public static int GetcounterWorkplaceType() { return counterWorkplaceType; }



        public void SetWorkplaceTypeId() { workplaceTypeId = numberToAssaignToWorkplaceTypeId++; }
       
        public void SetWorkplaceTypeDetails(string paramWorkplaceTypeDetails) { workplaceTypeDetails = paramWorkplaceTypeDetails; }


        public void AddWorkerType(WorkerType paramObj)
        {
            for (int i = 0; i < workerTypes.Length; i++)
            {
                if (workerTypes[i] == null)
                {
                    workerTypes[i] = paramObj;
                    return;
                }
            }
        }


        public override string ToString()
        {
            string st = $"{workplaceTypeId}:{workplaceTypeDetails}\n";
            st += "Worker types:\n";
            for (int i = 0; workerTypes[i] != null && i < workerTypes.Length; i++)
            {
                st += $"{workerTypes[i].GetWorkerTypeId()}: {workerTypes[i].GetWorkerTypeDetails()}\n";
            }
            return st;
        }
    }
}
