using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFacroty.Interface;

namespace AbstractFacroty.Implementation.Nokia
{
    public class AshaSimple : ISimple
    {
        public string GetName()
        {
            return "Asha Simple";
        }
    }
}
