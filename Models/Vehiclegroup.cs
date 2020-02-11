using System;
using System.Collections.Generic;

namespace EF_API_CRUD.Models
{
    public partial class Vehiclegroup
    {
        public Vehiclegroup()
        {
            Vehicle = new HashSet<Vehicle>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Colour { get; set; }
        public string Colourname { get; set; }
        public int? Enterpriseid { get; set; }
        public string Active { get; set; }

        public virtual ICollection<Vehicle> Vehicle { get; set; }
    }
}
