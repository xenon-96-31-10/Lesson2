using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class CarService
    {
        private List<Car> _CScars;
        private List<Rent> _CSrentcars;
        public CarService(List<Car> CScars, List<Rent> CSrentcars)
        {
            _CScars = CScars;
            _CSrentcars = CSrentcars;
        
        }
        public List<Car> AVailableCars(DateTime from, DateTime to)
        {
            List<Car> availablecars = new List<Car>();
            for (int i = 0; i < _CSrentcars.Count; i++)
            {
                if ((from > _CSrentcars[i].getTo) || ((from < _CSrentcars[i].getFrom) && (to < _CSrentcars[i].getFrom)))
                {
                    if (availablecars.Contains(_CSrentcars[i].getName))
                    {
                        availablecars.Add(_CSrentcars[i].getName);
                    }
                }            
            }
                return availablecars;
        }
        public void MakeRent(Car selectedcar, DateTime from, DateTime to)
        {
            //getBD
            
            //saveBD
            
        }


    }
}
