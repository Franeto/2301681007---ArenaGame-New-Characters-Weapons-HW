using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ArenaGame.Weapons.Weapon;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace ArenaGame.Weapons
{
    public class Daggers : Weapon
    {
        public Daggers(Rarity rarity) : base(rarity)
        {
            Name += "Daggers";
            Damage += 10;
            Weight += 10;
        }

        public override int WeaponBonus() // Flurry Strike
        {
            int damage = 0;

            for(int i = 0; i < 5; i++) 
            {
                if (Helper.ThrowDice(33))
                {
                    damage += (Damage * 33) / 100;
                }
            }
            return damage;
        }
    }
}
