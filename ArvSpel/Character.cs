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


        // Detta är för att uppfylla kravet om "Utbyte av information sker mellan instanser"

        // Händelsehanterare för att lyssna på attacker mot spelaren
        public event Action<Character> Attacked;

        // Metod för att trigga händelsen när spelaren blir attackerad
        protected virtual void OnAttack(Character attacker) 
        {
            Attacked?.Invoke(attacker);
        }
    }
}

