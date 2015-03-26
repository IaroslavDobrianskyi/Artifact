using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class CarrierStep
    {
        public int CarrierStepId { get; set; }
        public string Description { get; set; }
        public CarrierActionInFlow CurrentActionId { get; set; }
        public List<StepAction> Actions { get; set; }
    }
}
