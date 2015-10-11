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
        public string getName
        {
            get { return _name; }       
        }
        public string getDescription
        {
            get { return _description; }        
        }
        public override string ToString()
        {
            return _name;
        }
    }
}
