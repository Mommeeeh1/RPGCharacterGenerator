using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgCharacterGenarator.Models
{
    public class Wizard : Player
    {
        public int Mana { get; set; }
        public List<SpecialAttack> SpecialAttacks { get; set; }

        public Wizard(string name, int strength, int intelligence, int mana)
            : base(name, strength, intelligence)
        {
            Mana = mana;
        }
    }
}
