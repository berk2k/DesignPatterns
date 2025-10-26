using Strategy.AttackTypes;

namespace Strategy.Models
{
    public abstract class Hero // Context class
    {
        private string heroName;
        private int HP = 100;
        private IHeroAttackType heroAttackType;

        public Hero(IHeroAttackType heroAttackType)
        {
            this.heroAttackType = heroAttackType;
        }

        public virtual void PerformAttack(Hero target)
        {
            if (target.HP <= 0)
            {
                Console.WriteLine("It's already dead");
                return;
            }

            this.heroAttackType.Attack(target);
        }

        public abstract void Display();

        public string HeroName
        {
            get => heroName;
            set => heroName = value;
        }

        public int HPValue
        {
            get => HP;
            set => HP = value;
        }

        public IHeroAttackType HeroAttackType
        {
            get => heroAttackType;
            set => heroAttackType = value;
        }
        // Same with the function above
        //private IHeroAttackType _heroAttackType;

        //public IHeroAttackType GetHeroAttackType()
        //{
        //    return _heroAttackType;
        //}

        //public void SetHeroAttackType(IHeroAttackType value)
        //{
        //    _heroAttackType = value;
        //}
    }

}
