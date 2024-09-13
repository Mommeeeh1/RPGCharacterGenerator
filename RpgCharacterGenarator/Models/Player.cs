using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgCharacterGenarator.Models
{
    public class Player
    {
        public string Name { get; set; }
        public int Strength { get; set; }
        public int Intelligence { get; set; }

        public Player(string name, int strength, int intelligence)
        {
            Strength = strength;
            Name = name;
            Intelligence = intelligence;
  
        }

    }
}
