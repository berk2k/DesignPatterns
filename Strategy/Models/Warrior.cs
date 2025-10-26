using Strategy.AttackTypes;

namespace Strategy.Models
{
    public class Warrior : Hero
    {
        public Warrior(string name) : base(new Melee())
        {
            HeroName = name;
        }

        public override void Display()
        {
            Console.WriteLine("Hero name: " + HeroName);
            Console.WriteLine("Hero class: Warrior");
            Console.WriteLine("Attack type: " + HeroAttackType.GetType().Name);
            Console.WriteLine("Current HP: " + HPValue);
            Console.WriteLine();
        }
    }
}
