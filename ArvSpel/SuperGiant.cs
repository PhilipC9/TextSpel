using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvSpel
{
    class SuperGiant : Giant
    {
        public string UltimateAbility { get; set; }
        public int HealAmount { get; set; }


        // Boss ability
        public void UseUltimateAbility()
        {
            Console.Clear();
            Console.WriteLine($"{Name} använde sin ultimata ablity {UltimateAbility}!");

            // Heal
            Health += HealAmount;
            Console.WriteLine($"{Name} läker {HealAmount} HP.");
        }
    }
}
