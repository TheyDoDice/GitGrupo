using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace LlibreriaMinijoc.Classes
{
    public class Planet
    {
        public Vector3 Coords { get; private set; }
        public Dictionary<string, string> OtherInfo { get; private set; }
        public string Name { get; private set; }
        public string Filiation { get; private set; }
        public string Region { get; private set; }
        public string Sector { get; private set; }
        public string Natives { get; private set; }
        public string Image { get; private set; }
        public Dictionary<Planet, double> ClosestPlanets { get; set; }
        public bool HasPuppy = false;
        public bool Visited = false;
        public List<Route> Routes { get; set; }


        public Planet(Vector3 coords, Dictionary<string, string> otherInfo, string name, string filiation, 
                      string region, string sector, string natives, string image)
        {
            Coords = coords;
            OtherInfo = otherInfo;
            Name = name;
            Filiation = filiation;
            Region = region;
            Sector = sector;
            Natives = natives;
            Image = image;
        }

    }
}
