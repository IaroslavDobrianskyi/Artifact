using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DataAccess
{
    public class ArtifactContext : DbContext
    {
        public DbSet<CarrierStep> CarrierSteps { get; set; }
        public DbSet<CarrierActionInFlow> CarrierActionsInFlow { get; set; }
        public DbSet<StepAction> StepActions { get; set; }

        public ArtifactContext() : base("ArtifactConnection") { }
    }
}
