using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesTest.Figures
{
    public abstract class Shape
    {
        public Shape(string n) 
        { 
            name = n;
        }
        public abstract double GetArea();
        public string Name { get => name; }

        private string name;
    }
}
