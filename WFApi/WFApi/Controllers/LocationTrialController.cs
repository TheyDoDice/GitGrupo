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
    [RoutePrefix("api/locationtrial")]
    public class LocationTrialController : ApiController
    {
        private WFModels db = new WFModels();

        // GET: api/LocationTrial
        public IQueryable<LocationTrial> GetLocationTrial()
        {
            return db.LocationTrial.Include(x=>x.Location).Include(y=>y.Trial);
        }

        [Route("location/{id}")]
        [ResponseType(typeof(IQueryable<Trial>))]
        public IQueryable<LocationTrial> GetLocationTrialByLocation(int id)
        {
            return db.LocationTrial.Include(x => x.Location).Include(y => y.Trial).Where(x=>x.IdLocation == id);
        }

        // GET: api/LocationTrial/5
        [ResponseType(typeof(LocationTrial))]
        public async Task<IHttpActionResult> GetLocationTrial(int id)
        {
            LocationTrial locationTrial = await db.LocationTrial.FindAsync(id);
            if (locationTrial == null)
            {
                return NotFound();
            }

            return Ok(locationTrial);
        }

        // PUT: api/LocationTrial/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutLocationTrial(int id, LocationTrial locationTrial)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != locationTrial.Id)
            {
                return BadRequest();
            }

            db.Entry(locationTrial).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
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

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/LocationTrial
        [ResponseType(typeof(LocationTrial))]
        public async Task<IHttpActionResult> PostLocationTrial(LocationTrial locationTrial)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.LocationTrial.Add(locationTrial);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = locationTrial.Id }, locationTrial);
        }

        // DELETE: api/LocationTrial/5
        [ResponseType(typeof(LocationTrial))]
        public async Task<IHttpActionResult> DeleteLocationTrial(int id)
        {
            LocationTrial locationTrial = await db.LocationTrial.FindAsync(id);
            if (locationTrial == null)
            {
                return NotFound();
            }

            db.LocationTrial.Remove(locationTrial);
            await db.SaveChangesAsync();

            return Ok(locationTrial);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool LocationTrialExists(int id)
        {
            return db.LocationTrial.Count(e => e.Id == id) > 0;
        }
    }
}