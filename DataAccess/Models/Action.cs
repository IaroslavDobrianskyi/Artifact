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
    
    public partial class Action
    {
        public Action()
        {
            this.ActFlows = new HashSet<ActFlow>();
        }
    
        public int id { get; set; }
        public int idUser { get; set; }
        public int idStep { get; set; }
    
        public virtual ICollection<ActFlow> ActFlows { get; set; }
        public virtual Step Step { get; set; }
    }
}
