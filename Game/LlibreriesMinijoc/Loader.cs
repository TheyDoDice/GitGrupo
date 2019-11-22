using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using LlibreriaMinijoc.Classes;
using Planetes;
using System.Numerics;

namespace LlibreriaMinijoc
{
    public class Loader
    {
        public Dictionary<string, Planet> Planets;
        public Dictionary<string, Route> Routes;

        Random Generator = new Random();
        private double maximumLimitXY = 5000, maximumLimitZ = 1000;
        private string Path;
        private double FactorXY = 1000000, FactorZ = 100;

        public void LoadInfo ()
        {
            Planets = new Dictionary<string, Planet>();
            Routes = new Dictionary<string, Route>();


            using (StreamReader sr = new StreamReader(Path)) {

                Dictionary<string, Dictionary<string, string>> _Planets, _Routes;

                _Routes = XML.obtenerDadesXML(sr, "hyperspaceRoutes", "Route", "nameRoute");
                _Planets = XML.obtenerDadesXML(sr, "planets", "planet", "name");
                _Planets = Dades.dadesTotalsPlanetes(_Planets);

                SetCoords(_Planets);
                SetPlanets(_Planets);
                SetRoutes(_Routes);

            }

            SetClosestPlanets(3);
            SetDisponibleRoutes();



        }

        private void SetDisponibleRoutes()
        {
            foreach (KeyValuePair<string, Planet> reg in Planets)
            {
                reg.Value.Routes = new List<Route>();

                var info = from route in Routes
                           where route.Value.Start == reg.Value || route.Value.End == reg.Value
                           select route;

                foreach (var values in info)
                {
                    reg.Value.Routes.Add(values.Value);
                }
                
            }
        }

        public Vector3 GetRandomCoords ()
        {
            return new Vector3((float) (Generator.NextDouble() * maximumLimitXY), (float)(Generator.NextDouble() * maximumLimitXY), (float)(Generator.NextDouble() * maximumLimitZ));
        }

        private void SetClosestPlanets(int quant)
        {
            List<Planet> planets = Planets.Values.ToList();

            foreach (var planet in planets)
            {

                planet.ClosestPlanets = GetClosestPlanets(planet.Coords, quant, Planets);

            }
            
        }

        private void SetRoutes(Dictionary<string, Dictionary<string, string>> routes)
        {
            string routeName, routeStart, routeEnd;
            Planet start, end;

            foreach (KeyValuePair<string, Dictionary<string, string>> reg in routes)
            {
                routeName = reg.Key;
                routeStart = reg.Value["start"];
                routeEnd = reg.Value["end"];

                if (Planets.TryGetValue(routeStart, out start) && Planets.TryGetValue(routeEnd, out end))
                {
                    Routes.Add(routeName, new Route(routeName, Planets[routeStart], Planets[routeEnd]));
                }
            }
        }

        private void SetCoords(Dictionary<string, Dictionary<string, string>> planets)
        {
            foreach (KeyValuePair<string, Dictionary<string, string>> reg in planets)
            {
                reg.Value["lat"] = UnitsConversor(reg.Value["lat"]);
                reg.Value["long"] = UnitsConversor(reg.Value["long"]);
                reg.Value["parsecs"] = (Int32.Parse(reg.Value["parsecs"]) / FactorZ).ToString();
            }
        }

        private string UnitsConversor(string value)
        {
            string convertedUnits;
            char[] digits = value.ToCharArray();
            byte[] convertedValues = new byte[digits.Length];
            double convertedValue = 0;

            for (int i = 0; i < digits.Length; i++)
            {
                if (Char.IsDigit(digits[i]))
                {
                    convertedValues[i] = (byte) (digits[i] - '0');
                } else
                {
                    convertedValues[i] = (byte) ((digits[i] - 'A') + 10);
                }
            }

            for (
                int i = 0; i < convertedValues.Length; i++)
            {
                convertedValue += (long) (convertedValues[i] * Math.Pow(10, convertedValues.Length - 1 - i));
            }

            convertedValue /= FactorXY;

            convertedUnits = convertedValue.ToString();

            return convertedUnits;
        }

        private void SetPlanets(Dictionary<string, Dictionary<string, string>> planets)
        {
            Planet planet;
            string planetName, planetFiliation, planetNatives, planetSector, planetRegion, planetImage;
            Dictionary<string, string> planetinfo;
            Vector3 position;

            foreach (KeyValuePair<string, Dictionary<string, string>> item in planets)
            {
                planetName = item.Key;
                planetinfo = item.Value;
                position = new Vector3( float.Parse(planetinfo["lat"]),
                                        float.Parse(planetinfo["long"]),
                                        float.Parse(planetinfo["parsecs"]) );

                planetinfo.Remove("lat");
                planetinfo.Remove("long");
                planetinfo.Remove("parsecs");

                planetFiliation = planetinfo["filiation"];
                planetNatives = planetinfo["natives"];
                planetSector = planetinfo["sector"];
                planetRegion = planetinfo["region"];
                planetImage = planetinfo["planetImage"];

                planetinfo.Remove("filiation");
                planetinfo.Remove("natives");
                planetinfo.Remove("sector");
                planetinfo.Remove("region");
                planetinfo.Remove("planetImage");


                planet = new Planet(position, planetinfo, planetName, planetFiliation, planetRegion, planetSector, planetNatives, planetImage);

                Planets.Add(planetName, planet);
            }
        }

        public static Dictionary<Planet, double> GetClosestPlanets(Vector3 position, int quant, Dictionary<string, Planet> allPlanets) 
        {
            Dictionary<Planet, double> distances = new Dictionary<Planet,double>(), closest = new Dictionary<Planet,double>();
            List<KeyValuePair<Planet, double>> AllOrderedClosestPlanets;
            List<Planet> planets = allPlanets.Values.ToList<Planet>();

            foreach (Planet planet in planets)
            {
                if (planet.Coords != position)
                {
                    distances.Add(planet, Vector3.Distance(position, planet.Coords));
                }
            }

            IEnumerable<KeyValuePair<Planet, double>> allOrderedPlanets = from ele in distances
                                                                          orderby ele.Value ascending
                                                                          select ele;

            AllOrderedClosestPlanets = allOrderedPlanets.ToList();

            for (int i = 0; i < quant; i++)
            {
                closest.Add(AllOrderedClosestPlanets[i].Key, AllOrderedClosestPlanets[i].Value);
            }

            return closest;
        }

        public Loader (string path)
        {
            Path = path;
        }
    }
}
