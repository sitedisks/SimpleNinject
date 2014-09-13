using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleNinject
{
    class MySqlServerDal: IDataAccess
    {
        public void Add()
        {
            Console.WriteLine("Add new record to My SQL");
        }
    }
}
