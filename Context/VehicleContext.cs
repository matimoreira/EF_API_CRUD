using EF_API_CRUD.Models;
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

        public override IEnumerable<Vehiclebrand> GetAll()
        {
            return dbContext.Vehiclebrand.ToList();
        }

        public override IEnumerable<Vehiclebrand> GetByPage(int page, int pageSize)
        {
            return dbContext.Vehiclebrand.Skip(page * pageSize).Take(pageSize).ToList();
        }

        public override Vehiclebrand GetById(int id)
        {
            return dbContext.Vehiclebrand.SingleOrDefault(d => d.Id == id);
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
