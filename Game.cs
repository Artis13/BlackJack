using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Game
    {
        public Dealer dealer;
        public Player player;
        public Deck deck;




        public bool StartNewGame()
        {
            bool StartNew = Game.GetAnswer("Vai uzsākt jaunu spēli ");

            if (StartNew)
            {
                Console.WriteLine("Uzsākta jauna spēle ");
                Deck = new Deck();
                Dealer = new Dealer();
                Player = new Player();
            }

            return StartNew;

        }

        public static bool GetAnswer(string question)
        {
            Console.WriteLine(question +  "(jā/nē) ");
            string atbilde = Console.ReadLine().ToLower();
            bool answer = atbilde == "jā";

            return answer;
        }



    }
}
