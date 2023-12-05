using Facroty.Implementation;
using Facroty.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rectangle = Facroty.Implementation.Rectangle;

namespace Facroty
{
    public class ShapFacroty
    {

        public static IShape CreatShape(ShapType shapType)
        {
            IShape shape = null;
            switch (shapType)
            {
                case ShapType.Circle:
                    shape = new Circle();
                    break;
                case ShapType.Rectangle:
                    shape = new Rectangle();
                    break;
            }

            return shape;
        }



    }
}
