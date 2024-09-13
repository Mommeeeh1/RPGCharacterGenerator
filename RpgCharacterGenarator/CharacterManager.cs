using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgCharacterGenarator
{
    public class CharacterManager
    {
        // New instance of the Random class
        private static Random random = new Random();

        // Method to roll a random score between 3 and 18 
        public int RollAbilityScore()
        {
            return random.Next(3, 19); // Generates a number between 3 and 18 (inclusive)
        }
    }
}
