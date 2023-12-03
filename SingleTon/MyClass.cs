using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTon
{
    public sealed class MyClass
    {
        private static volatile MyClass Instance;
        private static object _lock = new object();
        private MyClass() { }

        public static MyClass GetInstance()
        {
            if (Instance == null)
            {
                lock (_lock)
                {
                    if (Instance == null)
                        Instance = new MyClass();
                }
            }

            return Instance;
        }

        public string serverName;
        public string databaseName;
        public string userName;
        public string password;

        public string connectionString;

      
        //-------------------------------------------------Add Class
        public string Connecting_string ( )
        { 
            connectionString = "Data Source="+serverName+";Initial Catalog="+databaseName+";User ID="+ userName + ";Password="+password+"";
            return  connectionString;
        }
    }
}

