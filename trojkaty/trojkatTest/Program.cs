using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trojkatTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Trojkat x;
            x = new Trojkat(2.0, 1.0, 2.2);
            Console.WriteLine(x);
            Console.WriteLine(x.Obwod());       //funkcja Obwod
            Console.WriteLine(x.Obwód);            //properties get Obwód
            /*
            x.C = 4;
            Console.WriteLine(x.Obwód);
            Console.WriteLine(x.Pole);
            */

            var y = new Trojkat();
            Console.WriteLine(y);
        }


    }

}
