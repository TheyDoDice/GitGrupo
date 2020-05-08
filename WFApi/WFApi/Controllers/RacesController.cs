using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using WFApi.Models;

namespace WFApi.Controllers
{
    public class RacesController : ApiController
    {
        private WFModels db = new WFModels();

        // GET: api/Races
        public IQueryable<Race> GetRace()
        {
            return db.Race;
        }

        // GET: api/Races/5
        [ResponseType(typeof(Race))]
        public async Task<IHttpActionResult> GetRace(int id)
        {
            Race race = await db.Race.FindAsync(id);
            if (race == null)
            {
                return NotFound();
            }

            return Ok(race);
        }

        // PUT: api/Races/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutRace(int id, Race race)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != race.Id)
            {
                return BadRequest();
            }

            db.Entry(race).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RaceExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Races
        [ResponseType(typeof(Race))]
        public async Task<IHttpActionResult> PostRace(Race race)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Race.Add(race);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = race.Id }, race);
        }

        // DELETE: api/Races/5
        [ResponseType(typeof(Race))]
        public async Task<IHttpActionResult> DeleteRace(int id)
        {
            Race race = await db.Race.FindAsync(id);
            if (race == null)
            {
                return NotFound();
            }

            db.Race.Remove(race);
            await db.SaveChangesAsync();

            return Ok(race);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool RaceExists(int id)
        {
            return db.Race.Count(e => e.Id == id) > 0;
        }
    }
}