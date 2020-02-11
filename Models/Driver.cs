using System;
using System.Collections.Generic;

namespace EF_API_CRUD.Models
{
    public partial class Driver
    {
        public Driver()
        {
            Vehicle = new HashSet<Vehicle>();
        }

        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Idnumber { get; set; }
        public string Driverlicense { get; set; }
        public DateTime? Driverlicenseexpirationdate { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Area { get; set; }
        public string Imageurl { get; set; }
        public int? Addressid { get; set; }
        public int? Enterpriseid { get; set; }
        public string Active { get; set; }

        public virtual Address Address { get; set; }
        public virtual ICollection<Vehicle> Vehicle { get; set; }
    }
}
