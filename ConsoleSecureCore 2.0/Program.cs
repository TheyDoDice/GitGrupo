using System;
using System.Data;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace ConsoleSecureCore_2._0
{
    class Program
    {
        static void Main()
        {
            //OBTENIR ID DE LA NAU Y EL PLANETA
            int idNave;
            int idPlaneta;

            DataRow deliveryData = ObenirDeliveryData(idNave, idPlaneta);

            if (DeliryDataCorrecte(deliveryData))
            {

                int missatge = GenerarRNG(5);
                byte[] publiKey = GenerarClaus(deliveryData, missatge);

            }
        }

        //FUNCIONES

        private static void GenerarClaus(DataRow deliveryData, string missatge)
        {
            //OBTENIR PLANETA
            int idPlanetaOrigen;

            RSACryptoServiceProvider RSA  = new RSACryptoServiceProvider();
            UnicodeEncoding ByteConverter = new UnicodeEncoding();
            byte[] dataToEncrypt          = ByteConverter.GetBytes(missatge);

            //Salvem la info de les claus en un XML.
            string publicKey  = RSA.ToXmlString(false);
            string privateKey = RSA.ToXmlString(true);

            //GUARDAR LAS LLAVES DONDE TOCA
            InsertarClaus(publicKey, privateKey, idPlanetaOrigen);


            byte[] encryptedData = RSAEncrypt(dataToEncrypt, RSA.ExportParameters(false), false);
            byte[] decryptedData = RSADecrypt(encryptedData, RSA.ExportParameters(true), false);

            Console.WriteLine("Text: {0}", ByteConverter.GetString(encryptedData));
            Console.WriteLine("Text: {0}", ByteConverter.GetString(decryptedData));
            Console.ReadKey();
        }

        public static byte[] RSAEncrypt(byte[] DataToEncrypt, RSAParameters RSAPublicKeyInfo, bool DoOAEPPadding)
        {
            using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
            {
                //RSA.ImportParameters(RSAPublicKeyInfo);
                return RSA.Encrypt(DataToEncrypt, DoOAEPPadding);
            }
        }

        public static byte[] RSADecrypt(byte[] DataToDecrypt, RSAParameters RSAPrivateKeyInfo, bool DoOAEPPadding)
        {
            using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
            {
                RSA.ImportParameters(RSAPrivateKeyInfo);
                return RSA.Decrypt(DataToDecrypt, DoOAEPPadding);
            }
        }

    }
}
