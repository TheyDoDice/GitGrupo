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
    public class LocationTrialsController : ControllerBase
    {
        private readonly WayFinderAPIContext _context;

        public LocationTrialsController(WayFinderAPIContext context)
        {
            _context = context;
        }

        // GET: api/LocationTrials
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LocationTrial>>> GetLocationTrial()
        {
            return await _context.LocationTrial.ToListAsync();
        }

        // GET: api/LocationTrials/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LocationTrial>> GetLocationTrial(int id)
        {
            var locationTrial = await _context.LocationTrial.FindAsync(id);

            if (locationTrial == null)
            {
                return NotFound();
            }

            return locationTrial;
        }

        // PUT: api/LocationTrials/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLocationTrial(int id, LocationTrial locationTrial)
        {
            if (id != locationTrial.Id)
            {
                return BadRequest();
            }

            _context.Entry(locationTrial).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LocationTrialExists(id))
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

        // POST: api/LocationTrials
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<LocationTrial>> PostLocationTrial(LocationTrial locationTrial)
        {
            _context.LocationTrial.Add(locationTrial);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLocationTrial", new { id = locationTrial.Id }, locationTrial);
        }

        // DELETE: api/LocationTrials/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<LocationTrial>> DeleteLocationTrial(int id)
        {
            var locationTrial = await _context.LocationTrial.FindAsync(id);
            if (locationTrial == null)
            {
                return NotFound();
            }

            _context.LocationTrial.Remove(locationTrial);
            await _context.SaveChangesAsync();

            return locationTrial;
        }

        private bool LocationTrialExists(int id)
        {
            return _context.LocationTrial.Any(e => e.Id == id);
        }
    }
}
