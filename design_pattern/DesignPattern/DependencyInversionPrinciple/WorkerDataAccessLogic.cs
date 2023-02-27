using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.DependencyInversionPrinciple
{
    public class WorkerDataAccessLogic : IWorkerDataAccessLogic
    {
        public Worker GetWorkerDetails(int id)
        {
            //In real time get the employee details from database
            //but here we have hard coded the employee details
            Worker emp = new Worker()
            {
                ID = id,
                Name = "Pratham",
                Department = "IT",
                Salary = 20000
            };
            return emp;
        }
    }
}
