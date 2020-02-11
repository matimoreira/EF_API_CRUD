using System;
using System.Collections.Generic;

namespace EF_API_CRUD.Models
{
    public partial class Vehicletype
    {
        public Vehicletype()
        {
            Vehicle = new HashSet<Vehicle>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public int? Enterpriseid { get; set; }
        public int? Maxspeed { get; set; }
        public string Active { get; set; }

        public virtual ICollection<Vehicle> Vehicle { get; set; }
    }
}
