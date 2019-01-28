using Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategiPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            
            OrdersReader reader = new OrdersReader(@"C:\Users\msemeniu\Desktop\StrategiFile.txt");

            var orders = reader.GetOrdersFromFile();
            Console.ReadKey();
         }
    }
}
