using Strategy.Models;

namespace Strategy.AttackTypes
{
    public class Ranged : IHeroAttackType
    {
        private static readonly Random rand = new Random();
        public void Attack(Hero target)
        {
            int val = rand.Next(0, 2);

            if (val == 0)
            {
                target.HPValue -= 40;
            }
            else
            {
                target.HPValue -= 20;
            }

            if (target.HPValue < 0)
                target.HPValue = 0; 
        }
    }
}
