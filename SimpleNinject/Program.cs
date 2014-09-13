using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;

namespace SimpleNinject
{
    class Program
    {
        static void Main(string[] args)
        {
            StandardKernel kernel = new StandardKernel(); // Create IoC container
            //kernel.Bind<IDataAccess>().To<SqlServerDal>(); //This container doing the following work:
            kernel.Bind<IDataAccess>().To<MySqlServerDal>();
            /*
            SqlServerDal dal = new SqlServerDal();
            MySqlServerDal mydal = new MySqlServerDal();
            */
            IDataAccess dal = kernel.Get<IDataAccess>();

            Order order = new Order(dal); //All the dal implement the IDataAccess can inject here
            //order.Ida = dal; //setter

            order.Add();

            Console.Read();
        }
    }
}
