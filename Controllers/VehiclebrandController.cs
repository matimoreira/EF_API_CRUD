using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EF_API_CRUD.Context;
using EF_API_CRUD.Models;

namespace EF_API_CRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiclebrandController : SuperController
    {
        public VehiclebrandController(trackingContext context) : base(context)
        {
        }

        // GET: api/Vehiclebrand
        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Vehiclebrand>>> GetVehiclebrand()
        {
            return await dbContext.Vehiclebrand.ToListAsync();
        }

        // GET: api/Vehiclebrand/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Vehiclebrand>> GetVehiclebrand(int id)
        {
            var vehiclebrand = await dbContext.Vehiclebrand.FindAsync(id);

            if (vehiclebrand == null)
            {
                return NotFound();
            }

            return vehiclebrand;
        }


        [HttpGet("page{page}&pageSize={pageSize}")]
        public async Task<ActionResult<IEnumerable<Vehiclebrand>>> GetVehiclebrand(int page, int pageSize)
        {
            return await dbContext.Vehiclebrand.ToListAsync();
        }

        // PUT: api/Vehiclebrand/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVehiclebrand(int id, Vehiclebrand vehiclebrand)
        {
            if (id != vehiclebrand.Id)
            {
                return BadRequest();
            }

            dbContext.Entry(vehiclebrand).State = EntityState.Modified;

            try
            {
                await dbContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VehiclebrandExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Vehiclebrand
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Vehiclebrand>> PostVehiclebrand(Vehiclebrand vehiclebrand)
        {
            dbContext.Vehiclebrand.Add(vehiclebrand);
            try
            {
                await dbContext.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (VehiclebrandExists(vehiclebrand.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetVehiclebrand", new { id = vehiclebrand.Id }, vehiclebrand);
        }
        [HttpPost]
        public async Task<ActionResult<IEnumerable<Vehiclebrand>>> PostVehiclebrand([FromBody]int page, [FromBody]int pageSize)
        {
            return await  dbContext.Vehiclebrand.Skip(page * pageSize).Take(pageSize).ToListAsync();
        }

        // DELETE: api/Vehiclebrand/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Vehiclebrand>> DeleteVehiclebrand(int id)
        {
            var vehiclebrand = await dbContext.Vehiclebrand.FindAsync(id);
            if (vehiclebrand == null)
            {
                return NotFound();
            }

            dbContext.Vehiclebrand.Remove(vehiclebrand);
            await dbContext.SaveChangesAsync();

            return vehiclebrand;
        }

        private bool VehiclebrandExists(int id)
        {
            return dbContext.Vehiclebrand.Any(e => e.Id == id);
        }
    }
}
