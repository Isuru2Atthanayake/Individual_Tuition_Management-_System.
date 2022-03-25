using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace pass
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 10;
            if (x > y)
                Console.Write("Pass");
            else
                Console.Write("fail");
                Console.Write("\t ok");
            Console.Read();
        }
    }
}
