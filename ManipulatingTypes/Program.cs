using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using System.Threading.Tasks;

namespace ManipulatingTypes
{
    class X
    {

    }

    class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                long l = 0;
                Type type1 = typeof(int);
                Type type2 = 3.GetType();
                Type type3 = l.GetType();
                Type type4 = typeof(X);
                Type type5 = "Hello".GetType();
                Console.WriteLine($"{type1}");
                Console.WriteLine($"{type2}");
                Console.WriteLine($"{type3}");
                Console.WriteLine($"{type4}");
                Console.WriteLine($"{type5}");

                var n = (int)Activator.CreateInstance("int");
            }
            catch (Exception ex)
            {
                var fullname = System.Reflection.Assembly.GetEntryAssembly().Location;
                var progname = Path.GetFileNameWithoutExtension(fullname);
                Console.Error.WriteLine($"{progname} Error: {ex.Message}");
            }

        }
    }
}
