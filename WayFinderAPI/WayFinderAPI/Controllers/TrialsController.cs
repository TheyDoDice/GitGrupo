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
    public class TrialsController : ControllerBase
    {
        private readonly WayFinderAPIContext _context;

        public TrialsController(WayFinderAPIContext context)
        {
            _context = context;
        }

        // GET: api/Trials
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Trial>>> GetTrial()
        {
            return await _context.Trial.ToListAsync();
        }

        // GET: api/Trials/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Trial>> GetTrial(int id)
        {
            var trial = await _context.Trial.FindAsync(id);

            if (trial == null)
            {
                return NotFound();
            }

            return trial;
        }

        // PUT: api/Trials/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTrial(int id, Trial trial)
        {
            if (id != trial.Id)
            {
                return BadRequest();
            }

            _context.Entry(trial).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TrialExists(id))
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

        // POST: api/Trials
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Trial>> PostTrial(Trial trial)
        {
            _context.Trial.Add(trial);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTrial", new { id = trial.Id }, trial);
        }

        // DELETE: api/Trials/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Trial>> DeleteTrial(int id)
        {
            var trial = await _context.Trial.FindAsync(id);
            if (trial == null)
            {
                return NotFound();
            }

            _context.Trial.Remove(trial);
            await _context.SaveChangesAsync();

            return trial;
        }

        private bool TrialExists(int id)
        {
            return _context.Trial.Any(e => e.Id == id);
        }
    }
}
