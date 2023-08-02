using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsApp13
{
    static class Allproperties
    {
        public static List<Owner> allproperty = new List<Owner>();
        
        public static void addProperty(Owner o, string data)
        {
            FileStream fs = new FileStream("Data.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write(data);
            sw.Close();
            fs.Close();
            allproperty.Add(o);
        }
        
        
    }
}
