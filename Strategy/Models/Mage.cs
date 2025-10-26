using Strategy.AttackTypes;

namespace Strategy.Models
{
    public class Mage : Hero
    {
        private int attackCount = 0;
        public Mage(string name) : base(new Magic())
        {
            HeroName = name;
        }

        public override void Display()
        {
            Console.WriteLine("Hero name: " + HeroName);
            Console.WriteLine("Hero class: Mage");
            Console.WriteLine("Attack type: " + HeroAttackType.GetType().Name);
            Console.WriteLine("Current HP: " + HPValue);
            Console.WriteLine();
        }

        public override void PerformAttack(Hero target)
        {
            base.PerformAttack(target);
            attackCount++;

            if(attackCount == 2) 
            {
                Console.WriteLine($"{HeroName} switches from Magic to Melee attack!");
                HeroAttackType = new Melee();
            }

        }
    }
}
