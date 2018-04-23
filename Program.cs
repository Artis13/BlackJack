using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            while (true)
            {
                if (!game.StartNewGame())
                {
                    break;
                }


            }

            Console.WriteLine("Spēle pabeigta! ");
            Console.ReadLine();



        }





    }
}
