using System;
using System.Collections.Generic;

namespace EF_API_CRUD.Models
{
    public partial class Geofencetype
    {
        public Geofencetype()
        {
            Geofence = new HashSet<Geofence>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public string Colour { get; set; }
        public int? Enterpriseid { get; set; }
        public string Active { get; set; }

        public virtual ICollection<Geofence> Geofence { get; set; }
    }
}
