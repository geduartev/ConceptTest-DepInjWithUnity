using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using Repository;

namespace DepInjWithUnity
{
    class Program
    {
        static void Main(string[] args)
        {
            // Carga el "container" donde declaramos la implementación de IRepository que queremos utilizar.
            var container = new UnityContainer();
            container.RegisterType<IRepository, SQLRepository>();

            // Primera forma de traer los métodos: inyectamos en el constructor de "MyService" la dependencia.
            MyService service = new MyService(container.Resolve<IRepository>());
            Console.WriteLine(service.GetData());
            Console.ReadLine();

            // Segunda forma de traer los métodos.
            // Unity resuelve la implementación.
            var sqlRepository = container.Resolve<IRepository>();
            Console.WriteLine(sqlRepository.GetData());
            Console.ReadLine();
        }
    }
}
