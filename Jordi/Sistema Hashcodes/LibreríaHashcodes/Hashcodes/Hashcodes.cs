using System;
using System.Collections;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Drawing;

namespace Hashcodes
{
    public class HashCodes
    {
        private static Hashtable TablaConEtiquetas = new Hashtable();
        private static Hashtable TablaIdentificadorTexto = new Hashtable();
        private static Hashtable TablaIdentificadorColores = new Hashtable();

        public string RutaArchivoHashcodes { get; set; }
        public string RutaArchivoTextos { get; set; }
        public string RutaArchivoColores { get; set; }
        public HashCodes(string RutaArchivoHashcodes, string RutaArchivoTextos, string RutaArchivoColores)
        {
            this.RutaArchivoHashcodes = RutaArchivoHashcodes;
            this.RutaArchivoTextos = RutaArchivoTextos;
            this.RutaArchivoColores = RutaArchivoColores;
        }

        public void LeerHashcodes (string category, string section)
        {
            bool read = false, InCategory = false;
            TablaConEtiquetas.Clear();
            string[] lines = File.ReadAllLines(RutaArchivoHashcodes);
            
            foreach (string line in lines)
            {
                if (line.StartsWith(category))
                {
                    InCategory = true;
                }
                if (InCategory)
                {
                    if ((line.StartsWith("/* " + section + " */") || line.Contains("/* Section_Generic */")))
                    {
                        read = true;
                        continue;
                    }
                    else if ((line.StartsWith("/* End_" + section + " */") || line.Contains("/* End_Section_Generic*/")))
                    {
                        read = false;
                        if (line.StartsWith("/* End_" + section + " */"))
                        {
                            InCategory = false;
                            break;
                        }
                    }
                    else
                    {
                        if (read)
                        {
                            string[] col = line.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                            if (!TablaConEtiquetas.ContainsKey(col[0]))
                            {
                                TablaConEtiquetas.Add(col[0], col[1]);
                            }
                        }
                    }
                }
            }
        }

        public string ObtenerIdentificadorHashcode(string NombreHashCode)
        {
            string value = NombreHashCode;

            if (TablaConEtiquetas.ContainsKey(NombreHashCode))
            {
                value = TablaConEtiquetas[NombreHashCode].ToString();
            }

            return value;
        }

        public string [] ObtenerValorHashcode(string NombreHashcode, Hashtable tabla)
        {
            string ValorNumerico;
            string[] ValorHashCode;

            if (Regex.IsMatch(NombreHashcode, @"^\d"))
            {

                ValorHashCode = tabla[NombreHashcode].ToString().Split(new[] { "--HT_Delimiter--" }, StringSplitOptions.None);
            }
            else
            {
                ValorNumerico = ObtenerIdentificadorHashcode(NombreHashcode);
                try
                {
                    ValorHashCode = tabla[ValorNumerico].ToString().Split(new[] { "--HT_Delimiter--" }, StringSplitOptions.None);
                }
                catch
                {
                    ValorHashCode = new string[] { "Error" };
                }
            }
            return ValorHashCode;
        }

        public void MontarTablaTextos(int idioma, string section)
        {
            string CadenasTexto;
            string[] lines = File.ReadAllLines(RutaArchivoTextos);

            LeerHashcodes("/* HT_Text */", section);

            foreach (string line in lines)
            {
                if (line.StartsWith("/*") || String.IsNullOrEmpty(line))
                {
                    continue;
                }
                else
                {
                    string[] col = line.Split(new string[] { "--HT_String_Delimiter--" }, StringSplitOptions.RemoveEmptyEntries);
                    if (!(TablaIdentificadorTexto.ContainsKey(col[0])))
                    {
                        CadenasTexto = col[idioma];
                        TablaIdentificadorTexto.Add(col[0], CadenasTexto);
                    }
                }
            }
        }

        public void MontarTablaColores(string section)
        {
            string Color;
            string[] lines = File.ReadAllLines(RutaArchivoColores);

            LeerHashcodes("/* HT_Text */", section);

            foreach (string line in lines)
            {
                if (line.StartsWith("/*") || String.IsNullOrEmpty(line))
                {
                    continue;
                }
                else
                {
                    string[] col = line.Split(new string[] { "--HT_String_Delimiter--" }, StringSplitOptions.RemoveEmptyEntries);
                    if (!(TablaIdentificadorColores.ContainsKey(col[0])))
                    {
                        Color = col[1]+ "--HT_Delimiter--" + col[2];
                        TablaIdentificadorColores.Add(col[0], Color);
                    }
                }
            }
        }

        public void CambiarTextos(Form formulario)
        {
            string item;
            foreach (DictionaryEntry key in TablaConEtiquetas)
            {
                item = key.Key.ToString();
                Control[] matches = formulario.Controls.Find(item, true);
                if (matches.Length == 1)
                {
                    try
                    {
                        System.Reflection.PropertyInfo property = matches[0].GetType().GetProperty("Text");
                        property.SetValue(matches[0], ObtenerValorHashcode(item, TablaIdentificadorTexto)[0], null);
                    }
                    catch { }
                }
                if (formulario.Text == item)
                {
                   formulario.Text = ObtenerValorHashcode(item, TablaIdentificadorTexto)[0];
                }
            }
        }

        public void CambiarColores(int modo, Form formulario)
        {
            string item;
            foreach (DictionaryEntry key in TablaConEtiquetas)
            {
                item = key.Key.ToString();
                Control[] matches = formulario.Controls.Find(item, true);
                if (matches.Length == 1)
                {
                    try
                    {
                        System.Reflection.PropertyInfo property = matches[0].GetType().GetProperty("BackColor");
                        property.SetValue(matches[0], (Color)ColorTranslator.FromHtml(ObtenerValorHashcode(item, TablaIdentificadorColores)[0]), null);
                    }
                    catch
                    { 
                    
                    }

                    try
                    {
                        System.Reflection.PropertyInfo property = matches[0].GetType().GetProperty("ForeColor");
                        property.SetValue(matches[0], (Color)ColorTranslator.FromHtml(ObtenerValorHashcode(item, TablaIdentificadorColores)[1]), null);
                    }
                    catch
                    {

                    }
                }
                if (formulario.Text == item)
                {
                    formulario.ForeColor = (Color)ColorTranslator.FromHtml(ObtenerValorHashcode(item, TablaIdentificadorColores)[1]);
                    formulario.BackColor = (Color)ColorTranslator.FromHtml(ObtenerValorHashcode(item, TablaIdentificadorColores)[0]);
                }
            }
        }
    }
}
