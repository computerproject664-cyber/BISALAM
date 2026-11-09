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
            Console.WriteLine("inter bot1 name");
            string bot1 =Console.ReadLine();
            Console.WriteLine("inter bot2 name");
            string bot2 =Console.ReadLine();
            string[] strings = { "HELLO", "how are you", "thanks", "i'm fine " };
            a[0] = new ChatterBot(bot1, strings);
            a[1]=new ChatterBot(bot2, strings);
            string str = "hello";
            Console.Write(str);
            Console.ReadLine();
            while(true) 
            {
                foreach(ChatterBot bot in a)
                {
                    str = bot.ReplyTo(str);
                    Console.WriteLine(bot.GetName() + ": " + str);
                    Console.ReadLine();
                }
            }

        }
    }
}
