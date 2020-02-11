using System;
using System.Collections.Generic;

namespace EF_API_CRUD.Models
{
    public partial class Alertnotification
    {
        public int Id { get; set; }
        public DateTime? Timestamp { get; set; }
        public int? Alerttype { get; set; }
        public int? Alertid { get; set; }
        public int? Geofenceid { get; set; }
        public int? Vehicleid { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public string Dismissed { get; set; }

        public virtual Alert Alert { get; set; }
        public virtual Geofence Geofence { get; set; }
    }
}
