using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFacroty.Interface;

namespace AbstractFacroty
{
    public abstract class AbstractionsPhoneFactory
    {
        public virtual ISmart GetSmart()
        {
            return null;}

        public virtual ISimple GetSimple()
        {
            return null;
        }
    }
}
