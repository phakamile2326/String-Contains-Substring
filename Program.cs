using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Contains_Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "do it now";
            string str2 = "empty";

            Console.WriteLine("\n");
            if (str.Contains("do"))
            {
                
                Console.WriteLine("str contains do");
            }
               else
            {
                Console.WriteLine("empty");
            }
            Console.WriteLine("\n\n");
            if (str2.Contains("d"))
            {
                Console.WriteLine("str2 contains d");
            }
            else
            {
                Console.WriteLine(" str2 = empty ");
            }
        
      

      

            Console.ReadKey();
        }
    }
}
