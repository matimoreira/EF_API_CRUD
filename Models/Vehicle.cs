using System;
using System.Collections.Generic;

namespace EF_API_CRUD.Models
{
    public partial class Vehicle
    {
        public Vehicle()
        {
            Gpsreporthistory = new HashSet<Gpsreporthistory>();
            Lastgpsreport = new HashSet<Lastgpsreport>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Licenseplate { get; set; }
        public string Seriesnumber { get; set; }
        public string Motornumber { get; set; }
        public string Gps { get; set; }
        public int? Enterpriseid { get; set; }
        public int? Vehiclemodelid { get; set; }
        public int? Vehiclegroupid { get; set; }
        public int? Vehicletypeid { get; set; }
        public int? Driverid { get; set; }
        public string Isinuse { get; set; }
        public string Active { get; set; }

        public virtual Driver Driver { get; set; }
        public virtual Vehiclegroup Vehiclegroup { get; set; }
        public virtual Vehiclemodel Vehiclemodel { get; set; }
        public virtual Vehicletype Vehicletype { get; set; }
        public virtual ICollection<Gpsreporthistory> Gpsreporthistory { get; set; }
        public virtual ICollection<Lastgpsreport> Lastgpsreport { get; set; }
    }
}
