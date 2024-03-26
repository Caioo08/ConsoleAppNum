using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cont = 1;

            while (cont <= 100)
            {
                Console.WriteLine(cont);
                cont++;
            }
            Console.ReadKey();
        }
    }
}
