using Strategy.AttackTypes;

namespace Strategy.Models
{
    public class Ranger : Hero
    {
        private int attackCount = 0;
        public Ranger(string name) : base(new Ranged())
        {
            HeroName = name;
        }

        public override void Display()
        {
            Console.WriteLine("Hero name: " + HeroName);
            Console.WriteLine("Hero class: Range");
            Console.WriteLine("Attack type: " + HeroAttackType.GetType().Name);
            Console.WriteLine("Current HP: " + HPValue);
            Console.WriteLine();
        }

        public override void PerformAttack(Hero target)
        {
            base.PerformAttack(target); // hero class
            attackCount++;

            if (attackCount == 3)
            {
                Console.WriteLine($"{HeroName} switches from Ranged to Melee attack!");
                HeroAttackType = new Melee();
            }
        }
    }
}
