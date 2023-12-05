using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facroty.Interface;

namespace Facroty.Implementation
{ class Rectangle : IShape
    {
        public double Width;
        public double Length;
        public string Draw()
        {
            return "Perimeter rectangular Is :"+(Length*Width).ToString();
        }
    }
}
