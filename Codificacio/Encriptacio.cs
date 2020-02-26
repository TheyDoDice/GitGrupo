using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace XifratCodificacio
{
    public class Encriptacio
    {
        RSACryptoServiceProvider RSA;

        public Encriptacio()
        {
            RSA = new RSACryptoServiceProvider();
        }

        private string GenerarRNG(int max)
        {
            return new Random().Next(max).ToString();
        }

        //FUNCIONS CLAUS

        //public string GenerarClaus(string missatge)
        //{
        //    //Salvem la info de les claus en un XML.
        //    string publicKey = RSA.ToXmlString(false);
        //    string privateKey = RSA.ToXmlString(true);

        //    //Insertar les claus a la base de dades.
        //    InsertarClaus(idPlaneta, publicKey, missatge);

        //    return privateKey;
        //}

        public string ObtenirClauPrivada()
        {
            return RSA.ToXmlString(true);
        }

        public string ObtenirClauPublica()
        {
            return RSA.ToXmlString(false);
        }

        //public void InsertarClaus(int idPlaneta, string publicKey, string missatge)
        //{
        //    if (context.ValidationCode.Where(x => x.idPlanet == idPlaneta) != null)
        //    {
        //        context.ValidationCode.Remove(context.ValidationCode.Where(x => x.idPlanet == idPlaneta).FirstOrDefault());
        //    }
        //    if (context.PlanetKeys.Where(x => x.idPlanet == idPlaneta) != null)
        //    {
        //        context.PlanetKeys.Remove(context.PlanetKeys.Where(x => x.idPlanet == idPlaneta).FirstOrDefault());
        //    }
        //    context.ValidationCode.Add(new ValidationCode() { idPlanet = idPlaneta, ValidationCode1 = missatge });
        //    context.PlanetKeys.Add(new PlanetKeys() { idPlanet = idPlaneta, XMLKey = publicKey });
        //    context.SaveChanges();
        //}

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
