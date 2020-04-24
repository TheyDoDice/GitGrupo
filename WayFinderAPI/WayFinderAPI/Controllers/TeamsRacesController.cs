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
    public class TeamsRacesController : ControllerBase
    {
        private readonly WayFinderAPIContext _context;

        public TeamsRacesController(WayFinderAPIContext context)
        {
            _context = context;
        }

        // GET: api/TeamsRaces
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TeamsRaces>>> GetTeamsRaces()
        {
            return await _context.TeamsRaces.ToListAsync();
        }

        // GET: api/TeamsRaces/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TeamsRaces>> GetTeamsRaces(int id)
        {
            var teamsRaces = await _context.TeamsRaces.FindAsync(id);

            if (teamsRaces == null)
            {
                return NotFound();
            }

            return teamsRaces;
        }

        // PUT: api/TeamsRaces/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTeamsRaces(int id, TeamsRaces teamsRaces)
        {
            if (id != teamsRaces.Id)
            {
                return BadRequest();
            }

            _context.Entry(teamsRaces).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TeamsRacesExists(id))
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

        // POST: api/TeamsRaces
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<TeamsRaces>> PostTeamsRaces(TeamsRaces teamsRaces)
        {
            _context.TeamsRaces.Add(teamsRaces);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTeamsRaces", new { id = teamsRaces.Id }, teamsRaces);
        }

        // DELETE: api/TeamsRaces/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TeamsRaces>> DeleteTeamsRaces(int id)
        {
            var teamsRaces = await _context.TeamsRaces.FindAsync(id);
            if (teamsRaces == null)
            {
                return NotFound();
            }

            _context.TeamsRaces.Remove(teamsRaces);
            await _context.SaveChangesAsync();

            return teamsRaces;
        }

        private bool TeamsRacesExists(int id)
        {
            return _context.TeamsRaces.Any(e => e.Id == id);
        }
    }
}
