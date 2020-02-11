using System;
using System.Collections.Generic;

namespace EF_API_CRUD.Models
{
    public partial class Enterprise
    {
        public Enterprise()
        {
            Geofence = new HashSet<Geofence>();
            VehiclebrandBackup = new HashSet<VehiclebrandBackup>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? Address { get; set; }
        public string Active { get; set; }
        public int? Reseller { get; set; }

        public virtual Address AddressNavigation { get; set; }
        public virtual ICollection<Geofence> Geofence { get; set; }
        public virtual ICollection<VehiclebrandBackup> VehiclebrandBackup { get; set; }
    }
}
