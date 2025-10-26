using Strategy.Models;

namespace Strategy.AttackTypes
{
    public class Melee : IHeroAttackType
    {
        public void Attack(Hero target)
        {
            target.HPValue -= 30;
        }
    }
}
