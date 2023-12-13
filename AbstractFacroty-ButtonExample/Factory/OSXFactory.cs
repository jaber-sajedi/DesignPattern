using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFacroty_ButtonExample.implementation;
using AbstractFacroty_ButtonExample.@interface;

namespace AbstractFacroty_ButtonExample.Factory
{
    class OSXFactory : IGuiFactory
    {
        public IButton createButton()
        {
            return new OSXButton();
        }
    }
}
