using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency
{
    public interface ITravelService
    {
        string DestinosOnVacation();
        string DestinosEconomicosOnVacation();
        string DestinosDecameron();
        string DestinosEconomicosDecameron();
    }
}
