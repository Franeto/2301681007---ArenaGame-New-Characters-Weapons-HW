using ArenaGame.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Heroes
{
    public class Rogue : Hero
    {
        private const int TripleDamageMagicLastDigit = 5;
        private const int HealEachNthRound = 3;
        private int attackCount;

        public Rogue(string name) : base(name, new Daggers(Weapon.Rarity.common))
        {
            attackCount = 0;
        }
        public Rogue(string name, Weapon weapon) : base(name, weapon)
        {
            attackCount = 0;
        }

        public override int Attack()
        {
            int attack = base.Attack();
            if (attack % 25 == TripleDamageMagicLastDigit)
            {
                attack = attack * 3;
            }
            attackCount = attackCount + 1;
            if (attackCount % HealEachNthRound == 0 && Helper.ThrowDice(25))
            {
                Heal(StartingHealth * 50 / 100);
            }
            return attack;
        }

        public override void TakeDamage(int incomingDamage)
        {
            if (Helper.ThrowDice(30)) incomingDamage = 0;
            base.TakeDamage(incomingDamage);
        }
    }
}
