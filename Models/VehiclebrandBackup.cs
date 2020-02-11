using System;
using System.Collections.Generic;

namespace EF_API_CRUD.Models
{
    public partial class VehiclebrandBackup
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Enterpriseid { get; set; }
        public string Active { get; set; }

        public virtual Enterprise Enterprise { get; set; }
    }
}
