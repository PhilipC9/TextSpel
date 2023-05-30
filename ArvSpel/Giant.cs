using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvSpel
{
    class Giant : Knight
    {
        public string SpecialAbility { get; set; }
        public int WeaponDamageBoost { get; set; }

        // Ablitiy för fiende
        public void UseSpecialAbility()
        {
            Console.Clear();
            Console.WriteLine($"{Name} använde sin ability {SpecialAbility}!");

            // ökar vapenskada
            Damage += WeaponDamageBoost;
        }
    }

}
