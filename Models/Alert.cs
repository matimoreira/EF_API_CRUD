using System;
using System.Collections.Generic;

namespace EF_API_CRUD.Models
{
    public partial class Alert
    {
        public Alert()
        {
            Alertnotification = new HashSet<Alertnotification>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Notifywhenarriving { get; set; }
        public string Notifywhenleaving { get; set; }
        public int? Enterpriseid { get; set; }
        public string Active { get; set; }

        public virtual ICollection<Alertnotification> Alertnotification { get; set; }
    }
}
