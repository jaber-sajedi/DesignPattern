using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFacroty_ButtonExample.@interface;

namespace AbstractFacroty_ButtonExample.@interface
{
    public interface IGuiFactory
    {
        IButton createButton();
    }
}
