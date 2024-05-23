using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Weapons
{
    public class Sword : Weapon
    {
        public Sword(Rarity rarity) : base(rarity)
        {
            Name += "Sword";
            Damage += 20;
            Weight += 20;
        }

        public override int WeaponBonus() // Heroic Slash
        {
            if (Helper.ThrowDice(70))
            {
                return Damage/80;
            }
            return 0;
        }
    }
}
