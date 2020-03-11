using System.Collections.Generic;
using EF_API_CRUD.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EF_API_CRUD.Context
{
    public abstract class SuperContext<T>
    {
        protected trackingContext dbContext;

        public SuperContext(trackingContext context)
        {
            dbContext = context;
        }

        public abstract Task<ActionResult<IEnumerable<T>>> GetAll();
        public abstract Task<ActionResult<IEnumerable<T>>> GetByPage(int page, int pageSize);
        public abstract T GetById(int id);
        public abstract void Add(T newT);
        public abstract void Update(T editedObj);
        public abstract void Remove(T obj);
    }
}
