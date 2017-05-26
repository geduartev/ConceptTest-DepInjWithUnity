using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decameron;
using OnVacation;

namespace TravelAgency
{
    public class TravelService : ITravelService
    {
        private IDecameron Decameron;
        private IOnVacation OnVacation;

        public TravelService(IDecameron iDecameron, IOnVacation iOnVacation)
        {
            this.Decameron = iDecameron;
            this.OnVacation = iOnVacation;
        }

        public string DestinosOnVacation()
        {
            return OnVacation.Destinos();
        }

        public string DestinosEconomicosOnVacation()
        {
            return OnVacation.DestinosBaratos();
        }

        public string DestinosDecameron()
        {
            return Decameron.ObtenerDestinos();
        }

        public string DestinosEconomicosDecameron()
        {
            return Decameron.ObtenerDestinosEnPromocion();
        }
    }
}
