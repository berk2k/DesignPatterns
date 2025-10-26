using Strategy.Models;

namespace Strategy.AttackTypes
{
    public interface IHeroAttackType
    {
        void Attack(Hero target);
    }
}
