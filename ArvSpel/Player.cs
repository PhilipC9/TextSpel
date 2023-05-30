using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvSpel
{
    class Player : Character
    {
        public string Weapon { get; set; }

        // Metod som hanterar spelarens attack på en fiende
        public override void Attack(Character enemy)
        {
            // Minskar fiendens hälsa med 20
            enemy.Health -= 20;

            // Skriver ut meddelande om spelarens attack
            Console.WriteLine($"{Name} attackerar {enemy.Name} med {Weapon} och gör 20 skada.");

            // Kontrollerar om fiendens hälsa är mindre än eller lika med noll
            if (enemy.Health <= 0)
            {
                // Skrivs ut om fienden har besegrats
                Console.WriteLine($"{enemy.Name} har besegrats!");
            }
            else
            {
                // Skriver ut hur mycket hp fienden har kvar
                Console.WriteLine($"{enemy.Name} har {enemy.Health} HP kvar.");
            }
        }
    }
}
