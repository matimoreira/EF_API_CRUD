using System;
using System.Collections.Generic;

namespace EF_API_CRUD.Models
{
    public partial class Address
    {
        public Address()
        {
            Driver = new HashSet<Driver>();
            Enterprise = new HashSet<Enterprise>();
        }

        public int Id { get; set; }
        public string Addressline1 { get; set; }
        public string Addressline2 { get; set; }
        public string Townorcity { get; set; }
        public int? State { get; set; }
        public string Active { get; set; }

        public virtual State StateNavigation { get; set; }
        public virtual ICollection<Driver> Driver { get; set; }
        public virtual ICollection<Enterprise> Enterprise { get; set; }
    }
}
