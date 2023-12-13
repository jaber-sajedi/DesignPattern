using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFacroty_ButtonExample.Factory;
using AbstractFacroty_ButtonExample.@interface;

namespace AbstractFacroty_ButtonExample
{
    public class AbstracFactory
    {
        public static IGuiFactory CreateFactory(ButtonType buttonType)
        {
            IGuiFactory iguiFactory = null;
            switch (buttonType)
            {
                case ButtonType.win: iguiFactory =new WinFactory() ;
                    break;
                case ButtonType.OSX:
                    iguiFactory = new OSXFactory();
                    break;
            }
            
            return iguiFactory;
        }
    }
}
