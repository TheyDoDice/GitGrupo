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

        public void InsertCodification(int idPlanet, Dictionary<string, string> codificacio)
        {
            InnerEncryption innerEncryption = new InnerEncryption();
            innerEncryption.idPlanet = idPlanet;

            bd.InnerEncryption.Add(innerEncryption);

            int orderData = 1;

            foreach (KeyValuePair<string, string> keyValuePair in codificacio)
            {
                InnerEncryptionData innerData = new InnerEncryptionData();
                innerData.idInnerEncryptionData = bd.InnerEncryption.Last().idInnerEncryption;
                innerData.Word = keyValuePair.Key;
                innerData.Numbers = keyValuePair.Value;
                innerData.OrderData = short.Parse(orderData.ToString());
                orderData++;

                bd.InnerEncryptionData.Add(innerData);
                bd.SaveChanges();
            }
        }

        public Dictionary<string, string> GetCodification(int idPlanet)
        {
            Dictionary<string, string> codification = new Dictionary<string, string>();
            int idInnerEncryption;
            
            idInnerEncryption = bd.InnerEncryption.Where(x => x.idPlanet == idPlanet).FirstOrDefault().idInnerEncryption;

            codification = bd.InnerEncryptionData.Where(x => x.idInnerEncryptionData == idInnerEncryption).ToDictionary(x => x.Word, x => x.Numbers);

            return codification;
        }

    }
}
