using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleNinject
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlServerDal dal = new SqlServerDal();
            MySqlServerDal mydal = new MySqlServerDal();

            Order order = new Order(); //All the dal implement the IDataAccess can inject here
            order.Ida = dal;

            order.Add();

            Console.Read();
        }
    }
}
