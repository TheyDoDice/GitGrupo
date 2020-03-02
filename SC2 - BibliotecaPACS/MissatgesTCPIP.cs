using System;
using System.Collections.Generic;
using System.Linq;

namespace BibliotecaPACS
{
    class MissatgesTCPIP
    {
        public enum TipusMissatge { ER = 1, VR = 2, VK = 3, ERROR = 4 };
        Dictionary<string, string> msgFormats = new Dictionary<string, string>();

        public MissatgesTCPIP()
        {
            msgFormats.Add("ER", "ERMMDDYYYYSSSSSSSSSSSSCCCCCCCCCCCC");
            msgFormats.Add("VR", "VRSSSSSSSSSSSSRR");
            msgFormats.Add("VK", "VKCCCCCCCCCCCC");
        }

        public string CrearMissatgeEntryRequirement (string IdentificadorNau, string IdentificadorEntrega)
        {
            string MensajeER;
            string Fecha, str_IdentificadorNau, str_IdentificadorEntrega;

            Fecha = DateTime.Now.ToString("MMddyyyy");
            str_IdentificadorNau = IdentificadorNau.Trim();
            str_IdentificadorEntrega = IdentificadorEntrega.Trim();

            if (str_IdentificadorNau.Length < 12)
            {
                str_IdentificadorNau = str_IdentificadorNau.PadLeft(12, '0');
            }

            if (str_IdentificadorEntrega.Length < 12)
            {
                str_IdentificadorEntrega = str_IdentificadorEntrega.PadLeft(12, '0');
            }

            MensajeER = "ER" + Fecha + str_IdentificadorNau + str_IdentificadorEntrega;

            return MensajeER; 
        }

        public string CrearMissatgeValidationResult(string IdentificadorNau, string Resultat)
        {
            string MensajeVR;
            string str_IdentificadorNau;

            str_IdentificadorNau = IdentificadorNau.Trim();

            if (str_IdentificadorNau.Length < 12)
            {
                str_IdentificadorNau = str_IdentificadorNau.PadLeft(12, '0');
            }

            MensajeVR = "VR" + str_IdentificadorNau + Resultat;

            return MensajeVR;
        }

        public string CrearMissatgeValidationKey (string CodiValidacioEncriptat)
        {
            string MensajeVK;

            MensajeVK = "VK" + CodiValidacioEncriptat.Trim();

            return MensajeVK;
        }

        public TipusMissatge ObtenirTipusMissatge(string missatge)
        {
            string msg_aux = "";
            msg_aux = missatge.Substring(0, 2);

            if (msgFormats.ContainsKey(msg_aux))
            {
                string format = msgFormats.Where(x => x.Key == msg_aux).FirstOrDefault().Key;
                msg_aux = missatge.Substring(2);
                if (msg_aux.Length == msgFormats[format].Length)
                {
                    return (TipusMissatge)Enum.Parse(typeof(TipusMissatge), format);
                }
                else
                {
                    return TipusMissatge.ERROR;
                }
            }
            else
            {
                return TipusMissatge.ERROR;
            }
        }
    }
}
