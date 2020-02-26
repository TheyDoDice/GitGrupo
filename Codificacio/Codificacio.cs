using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XifratCodificacio
{
    public class Codificacio
    {
        char[] letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        public Dictionary<string, string> ObtenirCodificacio(int codeSize)
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
    }
}
