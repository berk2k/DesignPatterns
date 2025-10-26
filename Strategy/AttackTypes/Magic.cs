using Strategy.Models;

namespace Strategy.AttackTypes
{
    public class Magic : IHeroAttackType
    {
        private static readonly Random rand = new Random();
        public void Attack(Hero target)
        {
            int val = rand.Next(0, 5);

            if (val == 0)
            {
                target.HPValue -= 0;
            }
            else
            {
                target.HPValue -= 40;
            }

            if (target.HPValue < 0)
                target.HPValue = 0;
        }
    }
}
