using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFacroty_ButtonExample.@interface;

namespace AbstractFacroty_ButtonExample.implementation
{
    public class WinButton : IButton
    {
        public string GetName()
        {
            return "winButton";
        }

        public void paint()
        {
            throw new NotImplementedException();
        }
    }
}
