using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BBDD;

namespace BibliotecaPACS
{
    public class Codificacio
    {
        char[] letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        public Dictionary<string, string> CrearCodificacio(int codeSize)
        {
            List<string> randomCodes = new List<string>();
            Dictionary<string, string> codification = new Dictionary<string, string>();
            string code;

            foreach (char letter in letters)
            {
                do
                {
                    code = GenerarCodi(codeSize);
                } while (randomCodes.Contains(code));

                randomCodes.Add(code);
                codification.Add(letter.ToString(), code);

            }

            return codification;
        }

        public string GenerarCodi(int length)
        {
            Random random = new Random();
            return random.Next(0, length).ToString("D3");
        }

        public Dictionary<string, string> ObtenirCodificacio(int idPlanet)
        {
            Dictionary<string, string> codification = new Dictionary<string, string>();
            int idInnerEncryption;
            
            SContext context = new SContext();

           idInnerEncryption = context.InnerEncryption.Where(x => x.idPlanet == idPlanet).FirstOrDefault().idInnerEncryption;

          codification=  context.InnerEncryptionData.Where(x => x.idInnerEncryptionData == idInnerEncryption).ToDictionary(x => x.Word, x => x.Numbers);

           return codification;
            
        }
    }
}
