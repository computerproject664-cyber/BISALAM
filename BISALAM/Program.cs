using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BISALAM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ChatterBot[] a = new ChatterBot[2];
            string bot1 =Console.ReadLine();
            string bot2=Console.ReadLine();
            string[] strings = { "HELLO", "how are you", "thanks", "i'm fine " };
            a[0] = new ChatterBot(bot1, strings);
            a[1]=new ChatterBot(bot2, strings);
             
            while(true) 
            {
            }

        }
    }
}
