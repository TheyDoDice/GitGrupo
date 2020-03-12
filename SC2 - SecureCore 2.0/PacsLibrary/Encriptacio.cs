using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using BBDD;
using System.IO;

namespace PacsLibrary
{
    public class Encriptacio
    {
        SContext context = new SContext();

        public string GenerarRNG(int max)
        {
            return new Random().Next(max).ToString();
        }

        //FUNCIONS CLAUS

        public void GenerarClaus(string missatge, int idPlaneta)
        {
            
            CspParameters csp = new CspParameters();
            csp.KeyContainerName = "PlanetKey";


            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider(csp);
            RSA.PersistKeyInCsp = true;
            //Salvem la info de les claus en un XML.
            string publicKey = RSA.ToXmlString(false);
            //string privateKey = RSA.ToXmlString(true);

            //Insertar les claus a la base de dades.
            InsertarClaus(idPlaneta, publicKey, missatge);

            //return privateKey;
        }

        public void InsertarClaus(int idPlaneta, string publicKey, string missatge)
        {
            //ELIMINAR VALIDATION CODE & PLANET KEY
            if (context.ValidationCode.Where(x => x.idPlanet == idPlaneta) != null)
            {
                context.ValidationCode.Remove(context.ValidationCode.Where(x => x.idPlanet == idPlaneta).FirstOrDefault());
            }
            if (context.PlanetKeys.Where(x => x.idPlanet == idPlaneta) != null)
            {
                context.PlanetKeys.Remove(context.PlanetKeys.Where(x => x.idPlanet == idPlaneta).FirstOrDefault());
            }

            //INSERTAR VALIDATION CODE & PLANET KEY
            context.ValidationCode.Add(new ValidationCode() { idPlanet = idPlaneta, ValidationCode1 = missatge });
            context.PlanetKeys.Add(new PlanetKeys() { idPlanet = idPlaneta, XMLKey = publicKey });
            context.SaveChanges();
        }

        public byte[] RSAEncrypt(byte[] DataToEncrypt, RSAParameters RSAPublicKeyInfo, bool DoOAEPPadding)
        {
            using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
            {
                RSA.ImportParameters(RSAPublicKeyInfo);
                return RSA.Encrypt(DataToEncrypt, DoOAEPPadding);
            }
        }

        public byte[] RSADecrypt(byte[] DataToDecrypt,  bool DoOAEPPadding)
        {
            CspParameters csp = new CspParameters();
            csp.KeyContainerName = "PlanetKey";
                                  
            using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider(csp))
            {
                string publicKey = RSA.ToXmlString(true);
                File.WriteAllText("c:\\temp\\PrivateKey.xml", publicKey);
                //RSA.ImportParameters(RSAPrivateKeyInfo);
                byte[] test = RSA.Decrypt(DataToDecrypt, DoOAEPPadding);
                return test;
            }
        }
    }
}
