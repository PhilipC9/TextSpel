using ArvSpel;
using System.Xml.Linq;

class Knight : Character
{
    public int Damage { get; set; }

    public override void Attack(Character player)
    {
        Console.Clear();
        Console.WriteLine($"{Name} är på väg att attackera...");

        // Generera en slumpmässig tangent som spelaren måste trycka för att undvika attacken
        ConsoleKey randomKey = GenerateRandomKey();

        Console.WriteLine($"Tryck på {randomKey} för att undvika attacken!");

        // Skapa en timer för att hantera attacklogiken
        Timer timer = new Timer(state =>
        {
            Console.WriteLine("Du undvek inte attacken.");
            player.Health -= Damage;
            Console.WriteLine($"{Name} träffar {player.Name} och gör {Damage} skada.");

            if (player.Health <= 0)
            {
                Console.WriteLine($"{player.Name} har besegrats!");
            }
            else
            {
                Console.WriteLine($"{player.Name} har {player.Health} HP kvar.");
            }
        }, null, 2000, Timeout.Infinite);

        // Läs av spelarens inmatning och kontrollera om den matchar den slumpmässiga tangenten
        ConsoleKeyInfo input = Console.ReadKey(intercept: true);

        if (input.Key == randomKey)
        {
            timer.Change(Timeout.Infinite, Timeout.Infinite);
            Console.WriteLine("Du undvek attacken!");
        }
        else
        {
            timer.Dispose();
            player.Health -= Damage;
            Console.WriteLine($"{Name} träffar {player.Name} och gör {Damage} skada.");

            if (player.Health <= 0)
            {
                Console.WriteLine($"{player.Name} har besegrats!");
            }
            else
            {
                Console.WriteLine($"{player.Name} har {player.Health} HP kvar.");
            }
        }
    }

    private ConsoleKey GenerateRandomKey()
    {
        Random random = new Random();
        ConsoleKey[] keys = { ConsoleKey.A, ConsoleKey.S, ConsoleKey.D, ConsoleKey.W };

        // Generera ett slumpmässigt index för att välja en tangent från arrayen
        int randomIndex = random.Next(keys.Length);
        return keys[randomIndex];
    }
}
