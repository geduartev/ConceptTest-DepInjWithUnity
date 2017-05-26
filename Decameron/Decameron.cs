using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decameron
{
    public class Decameron : IDecameron
    {
        public string ObtenerDestinos()
        {
            return "Destinos Decameron: San Andrés y Cartagena.";
        }

        public string ObtenerDestinosEnPromocion()
        {
            return "Destinos Decameron en Promoción: Cancún";
        }
    }
}
