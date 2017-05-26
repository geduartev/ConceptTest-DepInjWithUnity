using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnVacation
{
    public class OnVacation : IOnVacation
    {
        public string Destinos()
        {
            return "OnVacation: Villa de Leyva";
        }

        public string DestinosBaratos()
        {
            return "OnVacation Baratos: Cúcuta";
        }
    }
}
