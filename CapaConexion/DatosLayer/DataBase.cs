using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DatosLayer
{
    public class DataBase
    {
        public static String ConnectionString
        {
            get {
                return ConfigurationManager.ConnectionStrings["NWConnection"].ConnectionString;
            }
        } 
    }
}
