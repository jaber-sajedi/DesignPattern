using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFacroty.Interface;

namespace AbstractFacroty.Implementation.HTC
{
    public class TitanSmart : ISmart
    {
        public string GetName()
        {
            return "Titan Smart";
        }
    }
}
