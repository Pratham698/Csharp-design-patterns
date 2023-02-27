using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.DependencyInversionPrinciple
{
    public class WorkerBusinessLogic
    {
        IWorkerDataAccessLogic _IWorkerDataAccessLogic;
        public WorkerBusinessLogic()
        {
            _IWorkerDataAccessLogic = DataAccessFactory.GetWorkerDataAccessObj();
        }
        public Worker GetWorkerDetails(int id)
        {
            return _IWorkerDataAccessLogic.GetWorkerDetails(id);
        }
    }
}
