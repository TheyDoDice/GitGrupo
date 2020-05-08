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
    public class TrialsController : ApiController
    {
        private WFModels db = new WFModels();

        // GET: api/Trials
        public IQueryable<Trial> GetTrial()
        {
            return db.Trial;
        }

        // GET: api/Trials/5
        [ResponseType(typeof(Trial))]
        public async Task<IHttpActionResult> GetTrial(int id)
        {
            Trial trial = await db.Trial.FindAsync(id);
            if (trial == null)
            {
                return NotFound();
            }

            return Ok(trial);
        }

        // PUT: api/Trials/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutTrial(int id, Trial trial)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != trial.Id)
            {
                return BadRequest();
            }

            db.Entry(trial).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
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

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Trials
        [ResponseType(typeof(Trial))]
        public async Task<IHttpActionResult> PostTrial(Trial trial)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Trial.Add(trial);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = trial.Id }, trial);
        }

        // DELETE: api/Trials/5
        [ResponseType(typeof(Trial))]
        public async Task<IHttpActionResult> DeleteTrial(int id)
        {
            Trial trial = await db.Trial.FindAsync(id);
            if (trial == null)
            {
                return NotFound();
            }

            db.Trial.Remove(trial);
            await db.SaveChangesAsync();

            return Ok(trial);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TrialExists(int id)
        {
            return db.Trial.Count(e => e.Id == id) > 0;
        }
    }
}