using EF_API_CRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EF_API_CRUD.Context
{
    public class AlertContext : SuperContext<Alert>
    {
        public AlertContext(trackingContext context) : base(context)
        {
        }

        public override void Add(Alert newT)
        {
            dbContext.Alert.Add(newT);
        }

        public override IEnumerable<Alert> GetAll()
        {
            return dbContext.Alert.ToList();
        }

        public override Alert GetById(int id)
        {
            return dbContext.Alert.SingleOrDefault(d => d.Id == id);
        }

        public override void Remove(Alert obj)
        {
            dbContext.Alert.Remove(obj);
        }

        public override void Update(Alert editedObj)
        {
            dbContext.Alert.Update(editedObj);
        }
    }
}
