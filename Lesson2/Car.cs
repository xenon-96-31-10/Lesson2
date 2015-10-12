using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    public class Car
    {
        private string _name;
        private string _description;
        
        public Car(string name, string description)
        {
            _name = name;
            _description = description;
        }
        public string name
        {
            get { return _name; }       
        }
        public string description
        {
            get { return _description; }        
        }
        public override string ToString()
        {
            return _name;
        }
    }
}
