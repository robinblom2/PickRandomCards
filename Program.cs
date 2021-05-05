using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickRandomCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of cards to pick: ");
            string line = Console.ReadLine();

            if (int.TryParse(line, out int numberOfCards))                                  // If the convertion is successfull, the specified number of cards will be stored in "numberOfCards". 
            {
                foreach(string card in CardPicker.PickSomeCards(numberOfCards))             // This foreach loop executes Console.WriteLine(card) for each element in the array returned by PickSomeCards. When we call the method we specify that the array that gets created in the PickSomeCards()-method should be the size that the user typed in.
                {
                    Console.WriteLine(card);                                                // This loop both sets the size of the array (amount of elements), and specifies the amount of times the cards/elements should be printed to console. 
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
            }

            Console.ReadKey();
        }
    }
}
