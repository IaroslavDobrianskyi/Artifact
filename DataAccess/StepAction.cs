using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess
{
    public class StepAction
    {
        public int StepActionId { get; set; }
        public string Description { get; set; }

        public RequirementMask Requirement { get; set; }
        public GameActionResult Result { get; set; }
    }
}
