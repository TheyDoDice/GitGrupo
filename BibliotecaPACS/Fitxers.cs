using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaPACS
{
    public class Fitxers
    {
        public void GenerarFitxerPacs(int fileLength, Dictionary<string, string> codification, string valueFilePath, string keyFilePath, int numFitxers)
        {
            for (int i = 1; i <= numFitxers; i++)
            {

                StreamWriter letters = File.CreateText(keyFilePath + "\\PACSKey" + i + ".txt");
                StreamWriter numbers = File.CreateText(valueFilePath + "\\PACS" + i + ".txt");

                Random random = new Random();

                for (int z = 0; z < fileLength; z++)
                {
                    int index = random.Next(codification.Count);

                    string key = codification.ElementAt(index).Key;
                    string code = codification.ElementAt(index).Value;

                    letters.Write(key);
                    numbers.Write(code);
                }
                letters.Close();
                numbers.Close();
            }
        }

        public void DescodificarFitxers(string[] files, Dictionary<string, string> codification, string newFilePath)
        {
            StreamWriter pacs = File.CreateText(newFilePath);

            foreach (string file in files)
            {
                string text = File.ReadAllText(file);
                string code = "";

                for (int i = 0; i < text.Length; i++)
                {
                    code += text[i];
                    if (code.Length == codification.ElementAt(0).Value.Length)
                    {
                        pacs.Write(DecodeCode(code, codification));
                        code = "";
                    }
                }

            }
            pacs.Close();
        }

        public string DecodeCode(string code, Dictionary<string, string> codification)
        {
            return codification.Where(x => x.Value == code).FirstOrDefault().Key;
        }


        public bool CompararFitxers(string pathFile1, string pathFile2)
        {
            bool iguales = false;

            string hash1 = GetMD5HashFromFile(File.ReadAllText(pathFile1));
            string hash2 = GetMD5HashFromFile(File.ReadAllText(pathFile2));

            if (hash1 == hash2)
            {
                iguales = true;
            }

            return iguales;
        }

        protected string GetMD5HashFromFile(string NombreArchivo)
        {
            using (MD5 md5 = MD5.Create())
            {
                using (FileStream Stream = File.OpenRead(NombreArchivo))
                {
                    byte[] Hash = md5.ComputeHash(Stream);
                    return BitConverter.ToString(Hash).Replace("-", "").ToUpperInvariant();
                }
            }
        }
    }
}
