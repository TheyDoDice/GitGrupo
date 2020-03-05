using System;
using System.Collections.Generic;
using System.Linq;

namespace PacsLibrary
{
    public class MissatgesTCPIP
    {
        public enum TipusMissatge { EntryRequirement = 1, ValidationResult = 2, ValidationKey = 3, PacsSending = 4, ERROR = 5 };
        private Dictionary<string, string> msgFormats = new Dictionary<string, string>()
        {
            {"ER", "ERMMDDYYYYSSSSSSSSSSSSCCCCCCCCCCCC" },
            {"VR", "VRSSSSSSSSSSSSRR" },
            {"VK", "VKCCCCCCCCCCCC" },
            {"PC", "PCPACSRR"}
        };

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

        public string CrearMissatgeValidationResult(string IdentificadorNau, bool Resultat)
        {
            string MensajeVR;
            string str_IdentificadorNau;
            string resultat;

            str_IdentificadorNau = IdentificadorNau.Trim();

            if (str_IdentificadorNau.Length < 12)
            {
                str_IdentificadorNau = str_IdentificadorNau.PadLeft(12, '0');
            }

            if (Resultat)
            {
                resultat = "AG";
            }
            else
            {
                resultat = "AD";
            }

            MensajeVR = "VR" + str_IdentificadorNau + resultat;

            return MensajeVR;
        }

        public string CrearMissatgeValidationKey (string CodiValidacioEncriptat)
        {
            return "VK" + CodiValidacioEncriptat.Trim();
        }

        public string CrearMissatgePacsSending()
        {
            return "PCPACSRR";
        }

        public TipusMissatge ObtenirTipusMissatge(string missatge)
        {
            string msg_aux = "";
            msg_aux = missatge.Substring(0, 2);

            if (msgFormats.ContainsKey(msg_aux))
            {
                string format = msgFormats.Where(x => x.Key == msg_aux).FirstOrDefault().Key;
                msg_aux = missatge.Substring(format.Length);
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

        public string ObtenirIdNau(string missatge, TipusMissatge tipus)
        {
            if(tipus == TipusMissatge.EntryRequirement)
            {
                return missatge.Substring(10, 12);
            }
            else if (tipus == TipusMissatge.ValidationResult)
            {
                return missatge.Substring(2, 12);
            }
            else
            {
                return null;
            }
        }

        public bool ValidationResultValid (string missatge, string idNau)
        {
            if(ObtenirTipusMissatge(missatge) == TipusMissatge.ValidationResult)
            {
                if(missatge.Substring(2, 12) == idNau.PadLeft(12, '0'))
                {
                    return missatge.Substring(14) == "VP";
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
