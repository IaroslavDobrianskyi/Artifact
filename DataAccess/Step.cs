using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Step
    {
        public int StepId { get; set; }
        public string Description { get; set; }
        public List<StepAction> Actions { get; set; }
    }
}
