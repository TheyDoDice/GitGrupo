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
    public class LocationFinishedController : ApiController
    {
        private WFModels db = new WFModels();

        // GET: api/LocationFinished
        public IQueryable<LocationFinished> GetLocationFinished()
        {
            return db.LocationFinished;
        }

        // GET: api/LocationFinished/5
        [ResponseType(typeof(LocationFinished))]
        public async Task<IHttpActionResult> GetLocationFinished(int id)
        {
            LocationFinished locationFinished = await db.LocationFinished.FindAsync(id);
            if (locationFinished == null)
            {
                return NotFound();
            }

            return Ok(locationFinished);
        }

        // PUT: api/LocationFinished/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutLocationFinished(int id, LocationFinished locationFinished)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != locationFinished.Id)
            {
                return BadRequest();
            }

            db.Entry(locationFinished).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
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

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/LocationFinished
        [ResponseType(typeof(LocationFinished))]
        public async Task<IHttpActionResult> PostLocationFinished(LocationFinished locationFinished)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.LocationFinished.Add(locationFinished);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = locationFinished.Id }, locationFinished);
        }

        // DELETE: api/LocationFinished/5
        [ResponseType(typeof(LocationFinished))]
        public async Task<IHttpActionResult> DeleteLocationFinished(int id)
        {
            LocationFinished locationFinished = await db.LocationFinished.FindAsync(id);
            if (locationFinished == null)
            {
                return NotFound();
            }

            db.LocationFinished.Remove(locationFinished);
            await db.SaveChangesAsync();

            return Ok(locationFinished);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool LocationFinishedExists(int id)
        {
            return db.LocationFinished.Count(e => e.Id == id) > 0;
        }
    }
}