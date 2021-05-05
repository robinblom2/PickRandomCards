﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickRandomCards
{
    class CardPicker
    {
        static Random random = new Random();                                    // We declare a random number generator as a class-variable. 

        public static string[] PickSomeCards(int numberOfCards)                 // This method will generate a string array and then fill that string array with values from the two other methods RandomValue() and RandomSuit().  
        {
            string[] pickedCards = new string[numberOfCards];

            for (int i = 0; i < numberOfCards; i++)
            {
                pickedCards[i] = RandomValue() + " of " + RandomSuit();
            }

            return pickedCards;                                                 // After all of the cards have been randomly generated by the two other methods, this method returns the array to the Main-method where they get printed to the console. 
        }

        private static string RandomSuit()                                      // This method will use the Random number generator to generate random numbers. Depending on the generated number the method returns a different string. 
        {
            int value = random.Next(1, 5);                                      // Get a random number between 1 and 4. 

            if (value == 1)                                                     // If the random number is 1, return the string "Spades".
            {
                return "Spades";
            }
            if (value == 2)                                                     // If the random number is 2, return the string "Hearts".
            {
                return "Hearts";
            }
            if (value == 3)                                                     // If the random number is 3, return the string "Clubs". 
            {
                return "Clubs";
            }
            return "Diamonds";                                                  // If non of the above IF-statements where true, (random number is 4), return the string "Diamonds". 
        }

        private static string RandomValue()                                     // This method will use the Random number generator to generate random numbers. Depening on the generated number the method returns a different string. 
        {
            int value = random.Next(1, 14);                                     // Get a random number between 1 and 13.

            if (value == 1)                                                     // If the random number is 1, return the string "Ace".
            {
                return "Ace";
            }
            if (value == 11)                                                    // If the random number is 11, return the string "Jack". 
            {
                return "Jack";
            }
            if (value == 12)                                                    // If the random number is 12, return the string "Queen". 
            {
                return "Queen";
            }
            if (value == 13)                                                    // If the random number is 13, return the string "King". 
            {
                return "King";
            }

            return value.ToString();                                            // If non of the above IF-statements where true, (random number is 2-10), return the random value but convert it to string first. 
        }
    }
}
