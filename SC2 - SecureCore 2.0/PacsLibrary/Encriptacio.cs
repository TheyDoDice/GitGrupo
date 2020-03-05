using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using BBDD;

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

        public string GenerarClaus(DeliveryData delivery, string missatge, int idPlaneta)
        {
            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();

            //Salvem la info de les claus en un XML.
            string publicKey = RSA.ToXmlString(false);
            string privateKey = RSA.ToXmlString(true);

            //Insertar les claus a la base de dades.
            InsertarClaus(idPlaneta, publicKey, missatge);

            return privateKey;
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

        public byte[] RSADecrypt(byte[] DataToDecrypt, RSAParameters RSAPrivateKeyInfo, bool DoOAEPPadding)
        {
            using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
            {
                RSA.ImportParameters(RSAPrivateKeyInfo);
                return RSA.Decrypt(DataToDecrypt, DoOAEPPadding);
            }
        }
    }
}
