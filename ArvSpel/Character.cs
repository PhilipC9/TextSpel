using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvSpel
{
    class Character
    {
        // Karaktärens namn
        public string Name { get; set; }

        // Karaktärens hälsa
        public int Health { get; set; }

        // Virtuell metod för att utföra en attack på en fiende
        public virtual void Attack(Character enemy)
        {
       
        }
    }
}

