using EF_API_CRUD.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        public override async Task<ActionResult<IEnumerable<Alert>>> GetAll()
        {
            return await dbContext.Alert.ToListAsync();
        }

        public override Alert GetById(int id)
        {
            return dbContext.Alert.SingleOrDefault(d => d.Id == id);
        }

        public override async Task<ActionResult<IEnumerable<Alert>>> GetByPage(int page, int pageSize)
        {
            return await dbContext.Alert.Skip(page * pageSize).Take(pageSize).ToListAsync();
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
