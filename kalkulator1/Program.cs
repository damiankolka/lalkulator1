using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalkulator1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("0. wYJSCIE");
                Console.WriteLine("1. dodawanie");
                Console.WriteLine("2. odejmowanie");
                Console.WriteLine("3. mnożenie");
                int menuOption = Convert.ToInt32(Console.ReadLine());
                if (menuOption == 0)
                    break;
            }
        }
    }
}
