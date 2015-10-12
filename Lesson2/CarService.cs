using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class CarService
    {
        
        public Car[] AVailableCars(DateTime from, DateTime to, Rent[] rentcars)
        {
            Car[] availablecars = new Car[] {};
            for (int i = 0; i < rentcars.Length; i++)
            {
                if ((from > rentcars[i].getTo) || ((from < rentcars[i].getFrom)&&(to < rentcars[i].getFrom)))
                { 
                    if(Array.IndexOf(availablecars,rentcars[i].getName) == -1)
                    {
                        availablecars = new Car[] { new Car(rentcars[i].getName, rentcars[i].getDescription) };
                    }
                }            
            }
                return availablecars;
        }
        public void MakeRent(Car selectedcar, DateTime from, DateTime to, Rent[] rentcars )
        {
            //getBD
            rentcars = new Rent[] {new Rent(selectedcar, from, to)};
            //saveBD
            
        }


    }
}
