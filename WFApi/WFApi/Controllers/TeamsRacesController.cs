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
    public class TeamsRacesController : ApiController
    {
        private WFModels db = new WFModels();

        // GET: api/TeamsRaces
        public IQueryable<TeamsRaces> GetTeamsRaces()
        {
            return db.TeamsRaces;
        }

        // GET: api/TeamsRaces/5
        [ResponseType(typeof(TeamsRaces))]
        public async Task<IHttpActionResult> GetTeamsRaces(int id)
        {
            TeamsRaces teamsRaces = await db.TeamsRaces.FindAsync(id);
            if (teamsRaces == null)
            {
                return NotFound();
            }

            return Ok(teamsRaces);
        }

        // PUT: api/TeamsRaces/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutTeamsRaces(int id, TeamsRaces teamsRaces)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != teamsRaces.Id)
            {
                return BadRequest();
            }

            db.Entry(teamsRaces).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
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

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/TeamsRaces
        [ResponseType(typeof(TeamsRaces))]
        public async Task<IHttpActionResult> PostTeamsRaces(TeamsRaces teamsRaces)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.TeamsRaces.Add(teamsRaces);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = teamsRaces.Id }, teamsRaces);
        }

        // DELETE: api/TeamsRaces/5
        [ResponseType(typeof(TeamsRaces))]
        public async Task<IHttpActionResult> DeleteTeamsRaces(int id)
        {
            TeamsRaces teamsRaces = await db.TeamsRaces.FindAsync(id);
            if (teamsRaces == null)
            {
                return NotFound();
            }

            db.TeamsRaces.Remove(teamsRaces);
            await db.SaveChangesAsync();

            return Ok(teamsRaces);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TeamsRacesExists(int id)
        {
            return db.TeamsRaces.Count(e => e.Id == id) > 0;
        }
    }
}