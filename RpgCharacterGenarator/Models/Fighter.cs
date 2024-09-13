using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgCharacterGenarator.Models
{
    public class Fighter : Player 
    {
        public int Armor { get; set; }
        List<SpecialAttack> SpecialAttacks { get; set; }


        public Fighter(string name, int strength, int intelligence, int armor)
          : base(name, strength, intelligence)
        {
            Armor = armor;
        }
    }
}

