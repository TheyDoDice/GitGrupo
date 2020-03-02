using System;
using System.Data;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using BBDD;
using System.Linq;

namespace SecureCore_2._0
{
    class Program
    {
        private static SContext context = new SContext();

        static void Main()
        {
            //OBTENIR ID DE LA NAU Y EL PLANETA
            int idNau = 1;
            int idPlaneta = 2;

            //NAU FA PETICIO PER ENTRAR A LA NAU

            //PLANETA --> COMPROBAR DELIVERYDATA
            DeliveryData delivery = ObenirDeliveryData(idNau, idPlaneta);

            if (DeliryDataCorrecte(delivery))
            {
                string missatge = GenerarRNG(100000);
                Console.WriteLine("MISSATGE: " + missatge);

                //PLANETA --> GENERAR CLAUS
                string privatekey = GenerarClaus(delivery, missatge, idPlaneta);

                //NAU --> AGAFAR MISSATE Y ENCRIPTARLO PER ENTREGAR A LA NAU
                string publicKey   = context.PlanetKeys.Where(x => x.idPlanet == idPlaneta).FirstOrDefault().XMLKey;
                string missatgeNau = context.ValidationCode.Where(x => x.idPlanet == idPlaneta).FirstOrDefault().ValidationCode1;

                UnicodeEncoding ByteConverter = new UnicodeEncoding();
                byte[] missategeNauBytes = ByteConverter.GetBytes(missatgeNau);

                RSACryptoServiceProvider RSANau = new RSACryptoServiceProvider();
                RSANau.FromXmlString(publicKey);

                byte[] missatgeEncriptatNau = RSAEncrypt(missategeNauBytes, RSANau.ExportParameters(false), false);

                //PLANETA --> DESENCRIPTAR MISSATGE NAU
                RSACryptoServiceProvider RSAPlaneta = new RSACryptoServiceProvider();
                RSAPlaneta.FromXmlString(privatekey);

                string missatgeDesencriptat = ByteConverter.GetString(RSADecrypt(missatgeEncriptatNau, RSAPlaneta.ExportParameters(true), false));

                Console.WriteLine(missatgeDesencriptat);

                if (missatgeDesencriptat == missatge)
                {
                    Console.WriteLine("Correcte");
                }
                else
                {
                    Console.WriteLine("Error");
                }
            }
            else
            {
                Console.WriteLine("Delivery Data Incorrecte.");
            }

            Console.ReadKey();
        }


        //FUNCIONS GENERACIO RANDOM

        private static string GenerarRNG(int max)
        {
            return new Random().Next(max).ToString();
        }

        //FUNCIONS DELIVERYDATA

        private static bool DeliryDataCorrecte(DeliveryData delivery)
        {
            return delivery != null ? true : false;
        }

        // ----Falta el dia
        private static DeliveryData ObenirDeliveryData(int idNave, int idPlaneta)
        {
            return context.DeliveryData.Where(x => x.idPlanetDest == idPlaneta && x.idSpaceShip == idNave).FirstOrDefault();
        }

        //FUNCIONS CLAUS

        private static string GenerarClaus(DeliveryData delivery, string missatge, int idPlaneta)
        {
            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();

            //Salvem la info de les claus en un XML.
            string publicKey = RSA.ToXmlString(false);
            string privateKey = RSA.ToXmlString(true);

            //Insertar les claus a la base de dades.
            InsertarClaus(idPlaneta, publicKey, missatge);

            return privateKey;

            #region EXTRA
            //UnicodeEncoding ByteConverter = new UnicodeEncoding();
            //
            //byte[] dataToEncrypt = ByteConverter.GetBytes(missatge);
            //
            //byte[] encryptedData = RSAEncrypt(dataToEncrypt, RSA.ExportParameters(false), false);
            //byte[] decryptedData = RSADecrypt(encryptedData, RSA.ExportParameters(true), false);
            //Console.WriteLine("Text: {0}", ByteConverter.GetString(encryptedData));
            //Console.WriteLine("Text: {0}", ByteConverter.GetString(decryptedData));
            #endregion
        }

        private static void InsertarClaus(int idPlaneta, string publicKey, string missatge)
        {
            if (context.ValidationCode.Where(x => x.idPlanet == idPlaneta) != null)
            {
                context.ValidationCode.Remove(context.ValidationCode.Where(x => x.idPlanet == idPlaneta).FirstOrDefault());
            }
            if (context.PlanetKeys.Where(x => x.idPlanet == idPlaneta) != null)
            {
                context.PlanetKeys.Remove(context.PlanetKeys.Where(x => x.idPlanet == idPlaneta).FirstOrDefault());
            }
            context.ValidationCode.Add(new ValidationCode() { idPlanet = idPlaneta, ValidationCode1 = missatge });
            context.PlanetKeys.Add(new PlanetKeys() { idPlanet = idPlaneta, XMLKey = publicKey });
            context.SaveChanges();
        }

        public static byte[] RSAEncrypt(byte[] DataToEncrypt, RSAParameters RSAPublicKeyInfo, bool DoOAEPPadding)
        {
            using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
            {
                RSA.ImportParameters(RSAPublicKeyInfo);
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