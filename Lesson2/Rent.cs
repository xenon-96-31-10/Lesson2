using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Rent
    {
        private Car _RentCar;//название арендованной машины
        private DateTime _from;
        private DateTime _to;
        
        public Rent(Car RentCar, DateTime from, DateTime to)
        {
            _RentCar = RentCar;
            _from = from;
            _to = to;
        }

         public string getName
        {
            get { return _RentCar.getName; }
        }

         public string getDescription
         {
             get { return _RentCar.getDescription; }
         }

         public DateTime getFrom
         {
             get { return _from; }
         }

         public DateTime getTo
         {
             get { return _to; }
         }

    }
}
