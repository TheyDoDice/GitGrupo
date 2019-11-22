using System;

namespace LlibreriaMinijoc.Classes
{
    public class Route
    {
        public string Name { get; private set; }
        public Planet Start { get; private set; }
        public Planet End { get; private set; }

        public Route(string name, Planet start, Planet end)
        {
            Name = name;
            Start = start;
            End = end;
        }

    }
}
