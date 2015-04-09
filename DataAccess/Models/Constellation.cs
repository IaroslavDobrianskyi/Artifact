//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccess.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Constellation
    {
        public Constellation()
        {
            this.ConstellationBonus = new HashSet<ConstellationBonu>();
            this.UserArtifacts = new HashSet<UserArtifact>();
        }
    
        public int id { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public string Description { get; set; }
    
        public virtual ICollection<ConstellationBonu> ConstellationBonus { get; set; }
        public virtual ICollection<UserArtifact> UserArtifacts { get; set; }
    }
}
