using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFacroty.Interface;

namespace AbstractFacroty.Implementation.Samsung
{
    public class GalaxySmart : ISmart
    {
        public string GetName()
        {
            return "Galaxy Smart";
        }
    }
}
