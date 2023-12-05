using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFacroty.Interface;

namespace AbstractFacroty.Implementation.HTC
{
    public class GenueSimple : ISimple
    {
        public string GetName()
        {
            return "Genue Simple";
        }
    }
}
