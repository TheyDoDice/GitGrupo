using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaPACS
{
    class MissatgesTCPIP
    {
        public string CrearMissatgeEntryRequirement (string Data,string IdentificadorNau, string IdentificadorEntrega)
        {
            string Fecha = DateTime.ParseExact(Data, "dd'/'MM'/'yyyy", CultureInfo.InvariantCulture).ToString("yyyy'/'MM'/'dd")
        }

    }
}
