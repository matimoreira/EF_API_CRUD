using System;
using System.Collections.Generic;

namespace EF_API_CRUD.Models
{
    public partial class AlertVehicle
    {
        public int Id { get; set; }
        public int Vehicleid { get; set; }
        public int Ordering { get; set; }
    }
}
