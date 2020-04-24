using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WayFinderAPI.Data;
using WayFinderAPI.Models;

namespace WayFinderAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationFinishedsController : ControllerBase
    {
        private readonly WayFinderAPIContext _context;

        public LocationFinishedsController(WayFinderAPIContext context)
        {
            _context = context;
        }

        // GET: api/LocationFinisheds
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LocationFinished>>> GetLocationFinished()
        {
            return await _context.LocationFinished.ToListAsync();
        }

        // GET: api/LocationFinisheds/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LocationFinished>> GetLocationFinished(int id)
        {
            var locationFinished = await _context.LocationFinished.FindAsync(id);

            if (locationFinished == null)
            {
                return NotFound();
            }

            return locationFinished;
        }

        // PUT: api/LocationFinisheds/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLocationFinished(int id, LocationFinished locationFinished)
        {
            if (id != locationFinished.Id)
            {
                return BadRequest();
            }

            _context.Entry(locationFinished).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LocationFinishedExists(id))
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

        // POST: api/LocationFinisheds
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<LocationFinished>> PostLocationFinished(LocationFinished locationFinished)
        {
            _context.LocationFinished.Add(locationFinished);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLocationFinished", new { id = locationFinished.Id }, locationFinished);
        }

        // DELETE: api/LocationFinisheds/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<LocationFinished>> DeleteLocationFinished(int id)
        {
            var locationFinished = await _context.LocationFinished.FindAsync(id);
            if (locationFinished == null)
            {
                return NotFound();
            }

            _context.LocationFinished.Remove(locationFinished);
            await _context.SaveChangesAsync();

            return locationFinished;
        }

        private bool LocationFinishedExists(int id)
        {
            return _context.LocationFinished.Any(e => e.Id == id);
        }
    }
}
