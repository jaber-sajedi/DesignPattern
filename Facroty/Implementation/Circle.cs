using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facroty.Interface;

namespace Facroty.Implementation
{
     class Circle : IShape
     {
         public double Diameter;
        public string Draw()
        {
            return "Perimeter of the circle Is :" + (Diameter*314).ToString();
        }
    }
}
