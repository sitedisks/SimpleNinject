using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleNinject
{
    public class Order
    {
        //private readonly SqlServerDal dal = new SqlServerDal();
        private IDataAccess _ida;

        /*
        public Order(IDataAccess ida)
        {
            // Constructor injection
            _ida = ida;
            //private IDataAccess _ida = new SqlServerDal();
        }
        */
        // Setter injection
        public IDataAccess Ida
        {
            set { _ida = value; }
            get { return _ida; }
        }

        public void Add()
        {
            _ida.Add();
        }
    }
}
