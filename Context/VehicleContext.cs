using EF_API_CRUD.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EF_API_CRUD.Context
{
    public class VehiclebrandContext : SuperContext<Vehiclebrand>
    {
        public VehiclebrandContext(trackingContext context) : base(context)
        {
        }

        public override void Add(Vehiclebrand newT)
        {
            dbContext.Vehiclebrand.Add(newT);
        }

        public override async Task<ActionResult<IEnumerable<Vehiclebrand>>> GetAll()
        {
            return await dbContext.Vehiclebrand.ToListAsync();
        }

        public override async Task<ActionResult<IEnumerable<Vehiclebrand>>> GetByPage(int page, int pageSize)
        {
            return await dbContext.Vehiclebrand.Skip(page * pageSize).Take(pageSize).ToListAsync();
        }

        public override Vehiclebrand GetById(int id)
        {
            return dbContext.Vehiclebrand.SingleOrDefault(d => d.Id == id);
        }

        public double GetTotalPage(int pageSize)
        {
            
            float cantidad = Convert.ToSingle(dbContext.Vehiclebrand.Count());
            float resultado = cantidad / Convert.ToSingle(pageSize);

            return Math.Ceiling(resultado);
        }


        public override void Remove(Vehiclebrand obj)
        {
            dbContext.Vehiclebrand.Remove(obj);
        }

        public override void Update(Vehiclebrand editedObj)
        {
            dbContext.Vehiclebrand.Update(editedObj);
        }
    }
}
