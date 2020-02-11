using System;
using System.Collections.Generic;

namespace EF_API_CRUD.Models
{
    public partial class Geofence
    {
        public Geofence()
        {
            Alertnotification = new HashSet<Alertnotification>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public int? Radius { get; set; }
        public int? Enterpriseid { get; set; }
        public int? Geofencetypeid { get; set; }
        public string Active { get; set; }

        public virtual Enterprise Enterprise { get; set; }
        public virtual Geofencetype Geofencetype { get; set; }
        public virtual ICollection<Alertnotification> Alertnotification { get; set; }
    }
}
