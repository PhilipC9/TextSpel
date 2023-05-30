using ArvSpel;
using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        // Skapar en sinstans med namnet "Spelare", hälsa 100 och vapen "Svärd"
        Player player = new Player
        {
            Name = "Spelare",
            Health = 100,
            Weapon = "Svärd"
        };

        // Skapar en instans med namnet "Ond Riddare", hälsa 50 och skada 10
        Knight knight = new Knight
        {
            Name = "Ond Riddare",
            Health = 50,
            Damage = 10
        };

        // Skapar en instans med namnet "Jätte", hälsa 200, skada 30, speciell förmåga "Vapenkritisk träff" och vapenskadeboost 10
        Giant giant = new Giant
        {
            Name = "Jätte",
            Health = 200,
            Damage = 30,
            SpecialAbility = "Vapenkritisk träff",
            WeaponDamageBoost = 10
        };

        // Skapar en instans med namnet "Superjätte", hälsa 500, skada 50, speciell förmåga "Vapenförstärkning", vapenskadeboost 20, ultimat förmåga "Läkning" och läkningsmängd 50
        SuperGiant superGiant = new SuperGiant
        {
            Name = "Superjätte",
            Health = 500,
            Damage = 50,
            SpecialAbility = "Vapenförstärkning",
            WeaponDamageBoost = 20,
            UltimateAbility = "Läkning",
            HealAmount = 50
        };


        // Skriver ut meddelanden för att introducera spelets inledning
        Console.WriteLine("Du går mot ett stort slott...");
        Console.WriteLine("Tryck Enter för att fortsätta...");
        Console.ReadLine();

        Console.WriteLine("Det skramlade till från en stor buske...");
        Console.WriteLine("Tryck Enter för att fortsätta...");
        Console.ReadLine();

        Console.WriteLine($"En farlig {knight.Name} hoppade fram ur busken!");
        Console.WriteLine("Tryck på Enter för att slåss...");
        Console.ReadLine();

        // Kör en loop för strid mellan spelaren och riddaren tills någon av dem har noll hälsa
        while (player.Health > 0 && knight.Health > 0)
        {
            // Rensar konsolfönstret
            Console.Clear();

            // Spelaren attackerar riddaren
            player.Attack(knight);
            // Meddela att spelaren blev attackerad
            Thread.Sleep(4000);

            // Om riddaren fortfarande har hälsa kvar, kontrar den med att attackera spelaren
            if (knight.Health > 0)
            {
                Console.Clear();
                knight.Attack(player);
                Thread.Sleep(2000);
            }
        }

        Console.WriteLine("Tryck på Enter för att gå in i slottet...");
        Console.ReadLine();
        Console.Clear();

        // Skriver ut meddelande för jätten
        Console.WriteLine($"Den mäktiga {giant.Name} närmar sig!");

        Console.WriteLine("Tryck på Enter för att slåss...");
        Console.ReadLine();

        // Kör en loop för strid mellan spelaren och jätten tills någon av dem har noll hälsa
        while (player.Health > 0 && giant.Health > 0)
        {
            Console.Clear();
            player.Attack(giant);
            Thread.Sleep(2000);

            if (giant.Health > 0)
            {
                Console.Clear();
                giant.Attack(player);
                Thread.Sleep(2000);
            }
        }

        Console.Clear();

        // Skriver ut meddelande om att den slutgiltiga bossen närmar sig
        Console.WriteLine($"Den slutgiltiga bossen {superGiant.Name} närmar sig!");

        Console.WriteLine("Tryck på Enter för att slåss...");
        Console.ReadLine();

        // Jätten använder sin ability
        giant.UseSpecialAbility();
        Thread.Sleep(2000);

        Console.Clear();

        Console.WriteLine($"{player.Name} möter den omöjliga striden mot {superGiant.Name}!");
        Console.WriteLine("Tryck på Enter för att starta striden...");
        Console.ReadLine();

        // Kör en loop för strid mellan spelaren och superjätten tills någon av dem har noll hälsa
        while (player.Health > 0 && superGiant.Health > 0)
        {
            Console.Clear();
            player.Attack(superGiant);
            Thread.Sleep(2000);

            if (superGiant.Health > 0)
            {
                Console.Clear();
                superGiant.Attack(player);
                Thread.Sleep(2000);
            }
        }

        Console.Clear();

        // Skriver ut resultatet av striden beroende på om superjätten är besegrad eller inte
        if (superGiant.Health <= 0)
        {
            Console.WriteLine("Grattis! Du har besegrat Superjätten och vunnit spelet!");
        }
        else
        {
            Console.WriteLine("Du har besegrats av Superjätten. Spelet är över!");
        }

        Console.ReadLine();
    }
}
