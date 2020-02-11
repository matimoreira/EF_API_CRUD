using System;
using System.Collections.Generic;

namespace EF_API_CRUD.Models
{
    public partial class State
    {
        public State()
        {
            Address = new HashSet<Address>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? Countryid { get; set; }

        public virtual Country Country { get; set; }
        public virtual ICollection<Address> Address { get; set; }
    }
}
