using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ShiftScheduler
{
    internal class Workplace
    {   // במסד נתונים אני כתבתי בכמות עובדים דרושים למשמרת workers_amount_type_needed
        // לשנות ל workers_amount_needed
        int workplaceId;
        User managerArrow;
        string workplaceName;
        WorkplaceType workplaceTypeArrow;
        Worker[] workers;
        Shift[] shifts;

        static int counterWorkplace = 0;
        static int numberToAssignToWorkPlaceId = 1;


        public Workplace(User paramUserArrow, string paramWorkplaceName, WorkplaceType paramWorkplaceType) 
        {
            SetWorkplaceId();
            SetUserArrow(paramUserArrow);
            SetWorkplaceName(paramWorkplaceName);
            SetWorkplaceTypeArrow(paramWorkplaceType);
            workers = new Worker[250];
            shifts = new Shift[50];
            counterWorkplace++;
        }

        public Workplace(Workplace paramWorkplace) :this(paramWorkplace.managerArrow, paramWorkplace.workplaceName, paramWorkplace.workplaceTypeArrow) { }


        public int GetWorkplaceId() { return workplaceId; }
        
        public User GetManager() { return managerArrow; }
        
        public string GetWorkplaceName() { return workplaceName; }
        
        public WorkplaceType GetWorkplaceTypeArrow() { return workplaceTypeArrow; }

        public static int GetCounterWorkplace() { return counterWorkplace; }


        public void SetWorkplaceId() { workplaceId = numberToAssignToWorkPlaceId++; }
        
        public void SetUserArrow(User paramUserArrow) { managerArrow = paramUserArrow; }
        
        public void SetWorkplaceName(string paramWorkplaceName) { workplaceName = paramWorkplaceName; }
        
        public void SetWorkplaceTypeArrow(WorkplaceType paramWorkplaceTypeArrow) {  workplaceTypeArrow = paramWorkplaceTypeArrow; }


        public void AddWorkerToWorkers(Worker paramWorker)
        {
            for (int i = 0; i < workers.Length; i++)
            {
                if (workers[i] == null)
                {
                    workers[i] = paramWorker;
                    return;
                }
            }
        }


        public void AddShiftToShifts(Shift paramShift)
        {
            for (int i = 0; i < shifts.Length; i++)
            {
                if (shifts[i] == null)
                {
                    shifts[i] = paramShift;
                    return;
                }
            }
        }



        // tostring

    }
}
