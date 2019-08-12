using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonadestand
{
    public class Player
    {
        //Player player = new Player();
        Inventory inventory = new Inventory();

        public string name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string GetUserName()
        {
            Console.WriteLine("Please enter a player name for this game: ");
            name = Console.ReadLine();
            return name;
            

        }
        


        


        // members variables  has a








        //Constructor spawn

        // int Inventory = (Player player);





        //Member methods  can do


    }
    
}
