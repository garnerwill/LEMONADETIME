using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonadestand
{
    class Game
    {
        // member variable
        public Player player;
        public Weather lol;
        public Player name;
        public choice choice;



        // constructor
        public Game()
        {
            lol = new Weather();
            name = new Player();
            
        }

        // member methods
        public void RunGame()
        {
            DisplayRules();
            
            Console.WriteLine("Hello hello");
            
               



        }

        public void DisplayRules()
        {
            
            Console.WriteLine("These are the rules!");
            Console.WriteLine("You wont to start a Lemonade stand buisness but you don't know where to start. ");
            Console.WriteLine("So you ask you family for 500.00 to buy a stand and equipment.");
            Console.WriteLine("Now you have the stand and materials to start making some money.");
            Console.WriteLine("After everything you spent you have 50.00 left now it is time name your lemonade stand.");
            Console.WriteLine("What name are you going to call your stand." );
            Console.ReadLine();
            do
            {

                Console.WriteLine("1. Store");

                Console.WriteLine("2. Game");

                string choice = Console.ReadLine();

                switch (choice)

                {

                    case "1": // store

                        break;

                    case "2": // Game 

                        break;
                }

            }
            while (false);

            {
                Console.WriteLine("pick one or two");
                Console.ReadLine();
            }




        }   

    }
}
