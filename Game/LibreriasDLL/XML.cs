using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planetes
{
    public class XML
    {
        //FUNCIO PER COMPROVAR SI LA LINIA ES VALIDA
        public static bool SiLiniaValida(string linia)
        {
            bool valid;
            valid = linia.Length != linia.IndexOf('>') + 1;
            return valid;
        }
        //FUNCIONS OBTENIR TAG/ELEMENT
        public static string ObtenirTagXML(string linia)
        {
            string tag;
            int n = linia.IndexOf('>');
            tag = linia.Substring(1, n - 1);
            return tag;
        }

        public static string ObtenirElementXML(string linia)
        {
            string element;
            int n = linia.IndexOf('>') + 1;
            int m = linia.LastIndexOf('<');
            element = linia.Substring(n, m - n);
            return element;
        }

        //new
        public static string WriteLine(string tag, string value, int tab)
        {
            string line = "";

            line += AddTabulations(tab);
            line += AddTag(tag, true);
            line += value;
            line += AddTag(tag, false);

            return line;
        }

        public static string AddTag (string tag, bool first, int tab)
        {
            string s = "";

            s += AddTabulations(tab);
            
            s += (first? "<" : "</") + tag + ">\n";

            return s;
        }

        private static string AddTag (string tag, bool first)
        {
            string s = "";

            s += (first ? "<" : "</") + tag + ">" + (!first? "\n" : "");

            return s;
        }

        private static string AddTabulations(int n)
        {
            string tabs = "";

            for (int i = 0; i < n; i++) 
            {
                tabs += "   ";
            }

            return tabs;
        }

        private static void Avanzar(System.IO.StreamReader sr, string selectTag)
        {
            string linea;
            string tag;
            do
            {
                linea = sr.ReadLine().Trim();
                tag = XML.ObtenirTagXML(linea);
            } while (!tag.Equals(selectTag));
        }

        public static Dictionary<string, Dictionary<string, string>> obtenerDadesXML(System.IO.StreamReader sr, string tagini, string tagele, string tagkey)
        {
            Dictionary<string, Dictionary<string, string>> diccionario = new Dictionary<string, Dictionary<string, string>>();
            String linia, element, tag, key = "";
            Dictionary<string, string> infoPlaneta = new Dictionary<string,string>();

            Avanzar(sr, tagini);

            do
            {
                linia = sr.ReadLine().Trim();
                tag = XML.ObtenirTagXML(linia);
                if (XML.SiLiniaValida(linia))
                {

                    element = XML.ObtenirElementXML(linia);
                    if (tag == tagkey)
                    {
                        key = element;
                    }
                    else
                    {
                        infoPlaneta.Add(tag, element);
                    }

                }
                else if (tag.Equals("/" + tagele))
                {

                    diccionario.Add(key, infoPlaneta);

                    infoPlaneta = new Dictionary<string, string>();
                }
            } while (!tag.Equals("/" + tagini));

            return diccionario;
        }

        public static string WriteXMLFromDictDict(Dictionary<string, Dictionary<string, string>> planetasRegion, int tab, string global, string element, string tagkey)
        {
            string s = "";

            s += AddTag(global, true, tab);
            tab++;

            foreach (KeyValuePair<string, Dictionary<string, string>> planeta in planetasRegion)
            {
                s += AddTag(element, true, tab);
                tab++;
                s += WriteLine(tagkey, planeta.Key, tab);
                
                foreach (KeyValuePair<string, string> infoPlanet in planeta.Value)
                {
                    s += WriteLine(infoPlanet.Key, infoPlanet.Value, tab);
                }

                tab--;
                s += AddTag(element, false, tab);
            }

            tab--;
            s += AddTag(global, false, tab);

            return s;


        }
    }
}
