using System;
using System.Collections.Generic;

namespace EF_API_CRUD.Models
{
    public partial class Vehiclemodel
    {
        public Vehiclemodel()
        {
            Vehicle = new HashSet<Vehicle>();
        }

        public int Id { get; set; }
        public string Model { get; set; }
        public int? Year { get; set; }
        public int? Vehiclebrandid { get; set; }
        public string Active { get; set; }

        public virtual Vehiclebrand Vehiclebrand { get; set; }
        public virtual ICollection<Vehicle> Vehicle { get; set; }
    }
}
