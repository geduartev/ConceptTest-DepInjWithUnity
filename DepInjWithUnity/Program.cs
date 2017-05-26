using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using Repository;
using TravelAgency;

namespace DepInjWithUnity
{
    class Program
    {
        static void Main(string[] args)
        {
            /**************************************************************************/
            /* UTILIZANDO UNITY EN LA INYECCIÓN DE DEPENDENCIAS                       */
            /**************************************************************************/
            // Carga el "container" donde declaramos la implementación de IRepository que queremos utilizar.
            var container = new UnityContainer();
            container.RegisterType<IRepository, SQLRepository>();

            // Primera forma de traer los métodos: inyectamos en el constructor de "MyService" la dependencia.
            MyService myService = new MyService(container.Resolve<IRepository>());
            Console.WriteLine(myService.GetData());
            Console.ReadLine();

            // Segunda forma de traer los métodos.
            // Unity resuelve la implementación.
            var sqlRepository = container.Resolve<IRepository>();
            Console.WriteLine(sqlRepository.GetData());
            Console.ReadLine();

            /**************************************************************************/
            /* EJEMPLO DE IMPLEMENTACIÓN PARA APROVECHAR LA INYECCIÓN DE DEPENDENCIAS */
            /**************************************************************************/
            ITravelService service = TravelOperations.GetService();
            Console.WriteLine(service.DestinosOnVacation());
            Console.WriteLine(service.DestinosEconomicosOnVacation());
            Console.WriteLine(service.DestinosDecameron());
            Console.WriteLine(service.DestinosEconomicosDecameron());
            Console.ReadLine();
        }
    }
}
