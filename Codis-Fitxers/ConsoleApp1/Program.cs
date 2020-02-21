using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Compression;

namespace ConsoleApp1
{
    class Program
    {
        private static List<string> randomCodes = new List<string>();
        private static char[] letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        private static Dictionary<string, string> codification = new Dictionary<string, string>();
        private static int codeSize = 999;

        public static void Main(string[] args)
        {
            ///////////////////////
            //Generació codificació - Planeta
            codification = GetCodification(letters, codeSize);
            foreach(var code in codification)
            {
                Console.WriteLine(code.Key + ":  " + code.Value);
            }

            ///////////////////////
            //Generació fitxers - Planeta
            RandomString(500000, codification, "PACS1");
            RandomString(500000, codification, "PACS2");
            RandomString(500000, codification, "PACS3");

            string startPath = Application.StartupPath + "\\PACS";
            string zipPath = Application.StartupPath + "\\PACS.zip";
            string extractPath = Application.StartupPath + "\\PACSSOL";

            ZipFile.CreateFromDirectory(startPath, zipPath);


            ///////////////////////
            ///Descodificar fitxers - Nau
            ZipFile.ExtractToDirectory(zipPath, extractPath);

            string [] files = Directory.GetFiles(extractPath);
            string solutionFilePath = Application.StartupPath + "\\PACSSOL.txt";

            DecodeFiles(files, codification, solutionFilePath);

            if(EqualFiles(@"C:\Users\admin\source\repos\ConsoleApp1\ConsoleApp1\bin\Debug\PACS\PACS1numbers.txt", @"C:\Users\admin\source\repos\ConsoleApp1\ConsoleApp1\bin\Debug\PACSSOL\PACS1numbers.txt"))
            {
                Console.WriteLine("Iguales");
            }
            
        }
        

        public static Dictionary<string, string> GetCodification(char[] letters, int codeSize)
        {
            Dictionary<string, string> codification = new Dictionary<string, string>();
            string code;

            foreach (char letter in letters)
            {
                do
                {
                    code = GetLetterCode(codeSize);
                } while (randomCodes.Contains(code));

                randomCodes.Add(code);
                codification.Add(letter.ToString(), code);

            }

            return codification;
        }

        public static string GetLetterCode(int length)
        {
            Random random = new Random();
            return random.Next(0, length).ToString("D3");
        }

        public static string GetRandom()
        {
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                byte[] randomNumber = new byte[3];
                rng.GetBytes(randomNumber);
                int value = BitConverter.ToInt32(randomNumber, 0);
                return value.ToString();
            }
        }

        public static void RandomString(int length, Dictionary<string, string> codification, string name)
        {
            StreamWriter letters = File.CreateText(Application.StartupPath + "\\" + name + "letters.txt");
            StreamWriter numbers = File.CreateText(Application.StartupPath + "\\PACS\\" + name + "numbers.txt");
            
            Random random = new Random();

            for (int i = 0; i<length; i++)
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

        public static void DecodeFiles(string [] files, Dictionary<string, string> codification, string newFile)
        {

            StreamWriter pacs = File.CreateText(newFile);

            foreach (string file in files)
            {
                Console.WriteLine(file);
                string text = File.ReadAllText(file);
                Console.WriteLine(text.Length);
                string code = "";

                for (int i=0; i<text.Length; i++)
                {
                    code += text[i];
                    if(code.Length == codification.ElementAt(0).Value.Length)
                    {
                        pacs.Write(DecodeCode(code, codification));
                        code = "";
                    }
                }

            }
            pacs.Close();
        }

        public static string DecodeCode(string code, Dictionary<string, string> codification)
        {
            return codification.Where(x => x.Value == code).FirstOrDefault().Key;
        }


        public static bool EqualFiles(string path1, string path2)
        {
            string text1 = File.ReadAllText(path1);
            string text2 = File.ReadAllText(path2);

            return text1.GetHashCode() == text2.GetHashCode();

        }

    }
}
