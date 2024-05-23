using ArenaGame.Weapons;

namespace ArenaGame.Heroes
{
    public class Hero
    {
        public string Name { get; private set; }

        public int Health { get; private set; }

        public int Strength { get; private set; }

        public Weapon HeroWeapon { get; private set; }

        protected int StartingHealth { get; private set; }

        public bool IsDead { get { return Health <= 0; } }

        public Hero(string name)
        {
            Name = name;
            Health = 500;
            StartingHealth = Health;
            Strength = 100;
            HeroWeapon = new Fists(Weapon.Rarity.common);
        }
        public Hero(string name, Weapon weapon)
        {
            Name = name;
            Health = 500;
            StartingHealth = Health;
            Strength = 100;
            HeroWeapon = weapon;
        }

        public virtual int Attack()
        {
            return Strength * Random.Shared.Next(80, 121) / 100 + HeroWeapon.AddDamage();
        }

        public virtual void TakeDamage(int incomingDamage)
        {
            if (incomingDamage < 0) return;
            Health = Health - incomingDamage;
        }

        protected void Heal(int value)
        {
            Health = Health + value;
            if (Health > StartingHealth) Health = StartingHealth;
        }

        public void SwitchWeapon(Weapon weapon)
        {
            HeroWeapon = weapon;
        }
    }
}
