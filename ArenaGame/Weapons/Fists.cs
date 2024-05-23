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
    public class Fists : Weapon
    {
        public Fists(Rarity rarity) : base(rarity)
        {
            Name += "Fists";
        }

        public override int WeaponBonus()
        {
            if (Helper.ThrowDice(50)) // Uppercut
            {
                return (Damage * 50) / 100;
            }
            if(Helper.ThrowDice(50)) // Power Punch
            {
                return Damage;
            }
            return 0; // Normal Punch
        }
    }
}
