using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFacroty.Implementation;
using AbstractFacroty.Implementation.HTC;
using AbstractFacroty.Implementation.Nokia;
using AbstractFacroty.Implementation.Samsung;
using AbstractFacroty.Interface;

namespace AbstractFacroty
{
    class SamsungFactory: AbstractionsPhoneFactory
    {
        public override ISimple GetSimple()
        {
            return new PrimoSimple();
        }

        public override ISmart GetSmart()
        {
            return new GalaxySmart();
        }
    }

    class NokiaFactory:AbstractionsPhoneFactory
    {
        public override ISmart GetSmart()
        {
            return new LumiaSmart();
        }

        public override ISimple GetSimple()
        {
            return new AshaSimple();
        }
    }

    class HTCFactory : AbstractionsPhoneFactory
    {
        public override ISmart GetSmart()
        {
            return new  TitanSmart();
        }

        public override ISimple GetSimple()
        {
            return new GenueSimple();
        }
    }
}
 