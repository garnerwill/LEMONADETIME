using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonadestand
{
    public class Store
    {

        // members variables 
        //public int Lemon = 0;
        //public int Ice = 0;
        //public int sugar = 0;
        public double lemonPrice = .10;
        public double IcePrice = .10;
        public double sugarPrice = .10;
        public double Lemons;
        public double cupPrice = .10;

        public void SellLemons(Inventory inv)
        {
            Console.WriteLine("How many lemons you buy");
            int lemonsBought = int.Parse(Console.ReadLine());
            double totalCost = lemonsBought * lemonPrice;

            inv.Lemons += lemonsBought;
            inv.Wallet -= totalCost;



        }
        public void SellIce(Inventory inv)
        {
            Console.WriteLine("How much Ice did you buy");
            int IceBought = int.Parse(Console.ReadLine());
            double totalCost = IceBought * IcePrice;

            inv.Ice += IceBought;
            inv.Wallet -= totalCost;



        }

        public void SellSugar(Inventory inv)
        {
            Console.WriteLine("How much Ice did you buy");
            int sugarBought = int.Parse(Console.ReadLine());
            double totalCost = sugarBought * sugarPrice;


            inv.sugar += sugarBought;
            inv.Wallet -= totalCost;



        }

        public void SellCups(Inventory inv)
        {
            Console.WriteLine("How much Ice did you buy");
            int cupsBought = int.Parse(Console.ReadLine());
            double totalCost = cupsBought * cupPrice;


            inv.cups += cupsBought;
            inv.Wallet -= totalCost;



        }






    }

        



        //Constructor
        



        //Member methods 









}

