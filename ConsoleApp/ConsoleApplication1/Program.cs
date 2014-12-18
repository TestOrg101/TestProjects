using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean? con1 = null;
            //bool? con2 = false;
            if(con1.HasValue && con1.Value)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

            if(con1.HasValue  & con1.Value)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("False");
            }
            Console.ReadLine();
        }
    }
}
