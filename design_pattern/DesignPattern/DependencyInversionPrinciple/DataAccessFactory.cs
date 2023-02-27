using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.DependencyInversionPrinciple
{
    public class DataAccessFactory
    {
        public static IWorkerDataAccessLogic GetWorkerDataAccessObj()
        {
            //return new EmployeeDataAccessLogic();

            return new WorkerBriefDetail();

        }
    }
}
