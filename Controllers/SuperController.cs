
using EF_API_CRUD.Context;
using EF_API_CRUD.Models;
using Microsoft.AspNetCore.Mvc;
namespace EF_API_CRUD.Controllers
{
    public class SuperController : Controller
    {
        protected readonly trackingContext dbContext;

        public SuperController(trackingContext context)
        {
            dbContext = context;
        }
    }
}