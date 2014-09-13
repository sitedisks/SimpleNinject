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
            Order order = new Order();
            order.Add();

            Console.Read();
        }
    }

    public class Order
    {
        private readonly SqlServerDal dal = new SqlServerDal();
        public void Add()
        {
            dal.Add();
        }
    }

    public class SqlServerDal
    {
        public void Add()
        {
            Console.WriteLine("Add new record!");
        }
    }
}
