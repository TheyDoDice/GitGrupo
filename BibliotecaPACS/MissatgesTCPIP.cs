using System;

namespace BibliotecaPACS
{
    class MissatgesTCPIP
    {
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
    }
}
