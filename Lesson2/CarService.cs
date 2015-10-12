using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class CarService
    {
        public CarService()
        {

        }

        public Car[] AVailableCars(DateTime from, DateTime to, Rent[] rentcars)
        {
            Car[] availablecars = new Car[] {};
            
            return availablecars;
        }
        public void MakeRent(Car selectedcar, DateTime from, DateTime to, Rent[] rentcars )
        {
            rentcars = new Rent[] {new Rent(selectedcar, from, to)};
        }


    }
}
