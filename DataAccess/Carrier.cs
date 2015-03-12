using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DataAccess
{
    public class Carrier
    {
        public int CarrierId { get; set; }

        public int Strength {get;set;}
        public int Intellect{get;set;}
        public int Dexterity { get; set; }
    }
}
