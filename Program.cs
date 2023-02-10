using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labwork_10._02._2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*City city = new City();
            city.Enter();
            city.Print();

            city += 10;
            city.Print();

            City city2 = new City();
            city2.Enter();
            if(city == city2) {
                Console.WriteLine($"city == city2");
            }*/


            CreditCard card = new CreditCard();
            card.Enter();
            card += 25000;

            CreditCard card2 = new CreditCard();
            card2.Enter();

            if(card == card2) {
                Console.WriteLine("cvv card == cvv card2");
            }
            else { Console.WriteLine("cvv card != cvv card2"); }

            if(card > card2) {
                Console.WriteLine("card > card2");
            }



        }
    }
}
