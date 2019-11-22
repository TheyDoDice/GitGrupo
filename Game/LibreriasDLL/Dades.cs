using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planetes
{
    public class Dades
    {

        //FUNCIONS OBETENIR SECTOR/REGIO
        public static string obtenirRegio(string sectorregio)
        {
            string regio;

            regio = sectorregio.Substring(sectorregio.IndexOf('-') + 1);

            return regio;
        }

        public static string obtenirSector(string sectorregio)
        {
            string sector;

            sector = sectorregio.Substring(0, sectorregio.IndexOf('-'));

            return sector;
        }

        //FUNCIONS QUE RETORNEN LES DADES
        public static string[][] infoRutas(string planeta, Dictionary<string, Dictionary<string, string>> planetas, Dictionary<string, Dictionary<string, string>> rutas)
        {
            List<string[]> infoRutas = new List<string[]>();

            Dictionary<string, string> info = new Dictionary<string, string>();
            string[] infoRuta;
            string afiliacioStart;

            foreach (KeyValuePair<string, Dictionary<string, string>> reg in rutas)
            {
                if (reg.Value["start"].Equals(planeta))
                {

                    infoRuta = new string[6];
                    infoRuta[0] = reg.Value["type"];
                    infoRuta[1] = reg.Key;
                    infoRuta[2] = reg.Value["start"];
                    infoRuta[3] = reg.Value["end"];
                    afiliacioStart = planetas[planeta]["filiation"];
                    infoRuta[4] = planetas[reg.Value["end"]]["filiation"];
                    infoRuta[5] = infoRuta[4] == afiliacioStart ? "1" : "0";
                    infoRutas.Add(infoRuta);
                }
            }
            return infoRutas.ToArray();
        }
        //FUNCIO AMB LES DADES DELS PLANETES AMB RUTES I REGIONS
        public static Dictionary<string, Dictionary<string, string>> dadesTotalsPlanetes(Dictionary<string, Dictionary<string, string>> planetas)
        {
            string sectorregion, sector, region;

            foreach (KeyValuePair<string, Dictionary<string, string>> planeta in planetas)
            {

                sectorregion = planeta.Value["sector"];
                sector = obtenirSector(sectorregion);
                region = obtenirRegio(sectorregion);
                planetas[planeta.Key]["sector"] = sector;
                planetas[planeta.Key].Add("region", region);

            }
            return planetas;
        }

        //FUNCIO PER FER L'XML
        public static string dadesXMLPlanetesRegio(string region, Dictionary<string, Dictionary<string, string>> regiones, Dictionary<string, Dictionary<string, string>> planetas)
        {

            Dictionary<string, Dictionary<string, string>> planetasRegion = getPlanetasRegion(region, planetas);

            string xml;
            int tab = 0;
            xml = "<?xml version=\"1.0\" encoding=\"utf-8\"?>";
            xml += "\n";
            xml += XML.AddTag("region", true, tab);
            tab++;
            xml += XML.WriteLine("name", region, tab);

            foreach (KeyValuePair<string, string> reg in regiones[region])
            {
                xml += XML.WriteLine(reg.Key, reg.Value, tab);
            }

            xml += XML.WriteXMLFromDictDict(planetasRegion, tab, "planets", "planet", "name");

            tab--;
            xml += XML.AddTag("region", false, tab);


            return xml;
        }

        //FUNCIO PER LLISTAR ELS PLANETES PER REGIONS
        public static Dictionary<string, Dictionary<string, string>> getPlanetasRegion(string region, Dictionary<string, Dictionary<string, string>> planetas)
        {
            Dictionary<string, Dictionary<string, string>> planetasRegion = new Dictionary<string, Dictionary<string, string>>();

            foreach (KeyValuePair<string, Dictionary<string, string>> infoPlaneta in planetas)
            {
                string planetRegion;

                planetRegion = infoPlaneta.Value["region"];

                if (planetRegion.Equals(region))
                {
                    planetasRegion.Add(infoPlaneta.Key, infoPlaneta.Value);
                }
            }
            return planetasRegion;
        }
    }
    
}
