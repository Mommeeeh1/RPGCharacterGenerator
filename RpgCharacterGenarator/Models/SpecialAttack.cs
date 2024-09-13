using RpgCharacterGenarator.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgCharacterGenarator.Models
{
    public class SpecialAttack
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Roles roles { get; set; }

        public string Use()
        {
            return $"{Name} was used";
        }
    }
}
