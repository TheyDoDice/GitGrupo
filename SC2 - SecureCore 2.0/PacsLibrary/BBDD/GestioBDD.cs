using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BBDD;

namespace PacsLibrary.BBDD
{
    public class GestioBDD
    {
        SContext bd = new SContext();

        public void InsertPlanetIp (int planetId, string planetIp)
        {
            bd.Planets.Where(x => x.idPlanet == planetId).FirstOrDefault().IPPlanet = planetIp;
            bd.SaveChanges();
        }

        public void InsertSpaceshipIp(int spaceshipId, string spaceshipIp)
        {
            bd.SpaceShips.Where(x => x.idSpaceShip == spaceshipId).FirstOrDefault().IPSpaceShip = spaceshipIp;
            bd.SaveChanges();
        }
    }
}
