using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFacroty.Implementation;

namespace AbstractFacroty
{
    public class Abstract_Facroty
    {
        public static  AbstractionsPhoneFactory CreaeFacroty(TypePhone typePhone)
        {
            AbstractionsPhoneFactory Aphone = null;

            switch (typePhone)
            {
                case TypePhone.HTC:
                    Aphone = new HTCFactory();
                    break;
                case TypePhone.Nokia:
                    Aphone = new NokiaFactory();
                    break;
                case TypePhone.Samsung:
                    Aphone=  new SamsungFactory();
                    break;

            }
            return Aphone;
        }
    }
}
