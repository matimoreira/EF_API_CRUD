using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EF_API_CRUD.Models;
using EF_API_CRUD.Context;

namespace EF_API_CRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlertController : SuperController
    {
        public AlertController(trackingContext context) : base(context)
        {
        }

        // GET: api/Alert
        [HttpGet]
        public IEnumerable<Alert> GetAlert()
        {
            return dbContext.GetContext<AlertContext>().GetAll().ToList();
        }

        // GET: api/Alert/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Alert>> GetAlert(int id)
        {
            var alert = await dbContext.Alert.FindAsync(id);

            if (alert == null)
            {
                return NotFound();
            }

            return alert;
        }

        // PUT: api/Alert/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAlert(int id, Alert alert)
        {
            if (id != alert.Id)
            {
                return BadRequest();
            }

            dbContext.Entry(alert).State = EntityState.Modified;

            try
            {
                await dbContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AlertExists(id))
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

        // POST: api/Alert
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Alert>> PostAlert(Alert alert)
        {
            dbContext.Alert.Add(alert);
            try
            {
                await dbContext.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (AlertExists(alert.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetAlert", new { id = alert.Id }, alert);
        }

        // DELETE: api/Alert/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Alert>> DeleteAlert(int id)
        {
            var alert = await dbContext.Alert.FindAsync(id);
            if (alert == null)
            {
                return NotFound();
            }

            dbContext.Alert.Remove(alert);
            await dbContext.SaveChangesAsync();

            return alert;
        }

        private bool AlertExists(int id)
        {
            return dbContext.Alert.Any(e => e.Id == id);
        }
    }
}
