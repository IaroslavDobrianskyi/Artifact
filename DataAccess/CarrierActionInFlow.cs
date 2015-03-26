
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class CarrierActionInFlow
    {
        public int CarrierActionInFlowId { get; set; }
        public string Description { get; set; }
        public CarrierStep StepId { get; set; }
        public StepAction CarrierAction { get; set; }
    }
}
