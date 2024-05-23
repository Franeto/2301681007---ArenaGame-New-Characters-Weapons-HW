using ArenaGame.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Heroes
{
    public class Tank : Hero
    {
        private int fatigue;
        public Tank(string name) : base(name, new Sword(Weapon.Rarity.common))
        {
            fatigue = 0;
        }

        public Tank(string name, Weapon weapon) : base(name, weapon)
        {
            fatigue = 0;
        }
        public override int Attack()
        {
            int damage = base.Attack();

            damage = damage - ((fatigue*damage)/10);
            if(fatigue <= 5)
            {
                fatigue++;
            }
            return damage;
        }
        public override void TakeDamage(int incomingDamage)
        {
            if (Helper.ThrowDice(50))
            {
                incomingDamage = 0;
            }
            else
            {
                incomingDamage = incomingDamage / 2;
            }
            base.TakeDamage(incomingDamage);
        }
    }
}
