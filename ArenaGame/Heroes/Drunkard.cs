using ArenaGame.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Heroes
{
    public class Drunkard : Hero
    {
        private int drunkness;
        public Drunkard(string name) : base(name, new Fists(Weapon.Rarity.rare))
        {
            drunkness = 0;
        }

        public Drunkard(string name, Weapon weapon) : base(name, weapon)
        {
            drunkness = 0;
        }

        public override int Attack()
        {
            int damage = base.Attack();
            if (drunkness >= 100)
            {
                damage = (damage * 80) / 100;
            }
            return damage;
        }
        public override void TakeDamage(int incomingDamage)
        {
            base.TakeDamage(incomingDamage);
            DrinkAle();
        }
        public void DrinkAle()
        {
            Heal(50);
            drunkness += 25;
        }
    }
}
