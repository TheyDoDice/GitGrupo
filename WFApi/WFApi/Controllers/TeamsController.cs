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
    [RoutePrefix("api/teams")]
    public class TeamsController : ApiController
    {
        private WFModels db = new WFModels();

        // GET: api/Teams
        public IQueryable<Team> GetTeam()
        {
            return db.Team;
        }

        // GET: api/Teams/5
        [ResponseType(typeof(TeamDto))]
        public async Task<IHttpActionResult> GetTeam(int id)
        {
            Team team = await db.Team
                .Include(x => x.TeamsRaces)
                .FirstOrDefaultAsync(x => x.Id == id);

            TeamDto teamDto = new TeamDto();

            teamDto.Id = team.Id;
            teamDto.LocationFinished = team.LocationFinished;
            teamDto.Members = team.Member;
            teamDto.Name = team.Name;
            teamDto.Password = team.Password;

            foreach(var race in team.TeamsRaces)
            {
                teamDto.Races.Add(db.Race.Where(x => x.Id == race.IdRace).FirstOrDefault());
            }            

            if (teamDto == null)
            {
                return NotFound();
            }

            return Ok(teamDto);
        }

        //// GET: api/TeamMembers/5
        //[Route("members/{id:int}")]
        //[ResponseType(typeof(Member))]
        //public async Task<IHttpActionResult> GetTeamMembers(int id)
        //{
        //    Team team = await db.Team.FindAsync(id);
        //    ICollection<Member> member = team.Member;
        //    if (member == null)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(member);
        //}

        // GET: api/TeamMembers/5
        [Route("members/{id:int}")]
        public ICollection<Member> GetTeamMembers(int id)
        {
            Team team = db.Team.Find(id);
            ICollection<Member> member = db.Member.Where(x => x.TeamId == id).ToList();

            return member;
        }


        [ResponseType(typeof(Team))]
        [Route("Login/{name}/{password}")]
        public async Task<IHttpActionResult> GetLoginTeam(string name, string password)
        {
            try
            {
                Team team = await db.Team.Where(x => x.Name == name && x.Password == password).FirstAsync();
                return Ok(team);
            }
            catch
            {
                return NotFound();
            }
                    
        }

        // PUT: api/Teams/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutTeam(int id, Team team)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != team.Id)
            {
                return BadRequest();
            }

            db.Entry(team).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TeamExists(id))
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

        // POST: api/Teams
        [ResponseType(typeof(Team))]
        public async Task<IHttpActionResult> PostTeam(Team team)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Team.Add(team);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = team.Id }, team);
        }

        // DELETE: api/Teams/5
        [ResponseType(typeof(Team))]
        public async Task<IHttpActionResult> DeleteTeam(int id)
        {
            Team team = await db.Team.FindAsync(id);
            if (team == null)
            {
                return NotFound();
            }

            db.Team.Remove(team);
            await db.SaveChangesAsync();

            return Ok(team);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TeamExists(int id)
        {
            return db.Team.Count(e => e.Id == id) > 0;
        }
    }
}