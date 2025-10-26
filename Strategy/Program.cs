using Strategy.Models;

public class Program
{
    private static bool IsOneHeroRemaining(List<Hero> heroes)
    {
        int deathCount = 0;
        foreach (var hero in heroes)
        {
            if (hero.HPValue <= 0)
            {
                deathCount++;
            }
        }
        return deathCount >= heroes.Count - 1;
    }

    private static void DeclareWinner(List<Hero> heroes)
    {
        foreach (var hero in heroes)
        {
            if (hero.HPValue > 0)
            {
                Console.WriteLine($"Winner : {hero.HeroName}!!!");
            }
        }
    }

    public static void Main(string[] args)
    {
        var warrior = new Warrior("Leonidas");
        var ranger = new Ranger("Legolas");
        var mage = new Mage("Lestrange");

        var heroes = new List<Hero> { warrior, ranger, mage };

        warrior.Display();
        ranger.Display();
        mage.Display();

        while (!IsOneHeroRemaining(heroes))
        {
            Console.WriteLine("Select a Hero to attack with:");
            for (int i = 0; i < heroes.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {heroes[i].HeroName}");
            }

            int attackerIndex = int.Parse(Console.ReadLine());
            Console.WriteLine("Select a Hero to attack:");
            for (int i = 0; i < heroes.Count; i++)
            {
                if (i + 1 == attackerIndex) continue;
                Console.WriteLine($"{i + 1}. {heroes[i].HeroName}");
            }

            int defenderIndex = int.Parse(Console.ReadLine());
            Hero attacker = heroes[attackerIndex - 1];
            Hero defender = heroes[defenderIndex - 1];

            Console.WriteLine($"{attacker.HeroName} attacked {defender.HeroName}");
            attacker.PerformAttack(defender);
            attacker.Display();
            defender.Display();
        }

        DeclareWinner(heroes);
    }
}
