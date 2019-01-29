using Logic;
using Logic.Interfaces;
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
            AnalyticsStrategy strategy = new AnalyticsStrategy();
            OrdersManager ordersManager = new OrdersManager(strategy);
            ordersManager.Import(@"C:\Users\msemeniu\Desktop\StrategiFile.txt");
            ordersManager.PrintAnalitycs();

            Console.WriteLine("///////////////////////////////////////");

            AnalyticsStrategy avgStrategy = new AverageAnalyticStrategy();
            OrdersManager ordersManagerAvg = new OrdersManager(avgStrategy);
            ordersManagerAvg.Import(@"C:\Users\msemeniu\Desktop\StrategiFile.txt");
            ordersManagerAvg.PrintAnalitycs();

            string a = "Hello\nkolya";
            Console.WriteLine(a);

            Console.ReadKey();
         }
    }
}
