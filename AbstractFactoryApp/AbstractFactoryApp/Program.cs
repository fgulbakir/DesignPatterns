using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryApp.Factories;

namespace AbstractFactoryApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Client sportMan = new Client(new CasualClothesFactory() );
            sportMan.ChoosenClothes();
            Console.WriteLine($"Sportman prefer is : {sportMan.ChoosenClothes()}");


            Client businessMan = new Client(new ElegantClothesFactory());
            businessMan.ChoosenClothes();
            Console.WriteLine($"Businessman prefer is : {businessMan.ChoosenClothes()}");

            Console.ReadKey();

        }
    }
}
