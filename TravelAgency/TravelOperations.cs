using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;

namespace TravelAgency
{
    public class TravelOperations
    {
        private static IUnityContainer container = new UnityContainer();

        private static void RegisterType()
        {
            container.LoadConfiguration("Agencies");
        }

        public static ITravelService GetService()
        {
            RegisterType();
            return container.Resolve<ITravelService>();
        }
    }
}
