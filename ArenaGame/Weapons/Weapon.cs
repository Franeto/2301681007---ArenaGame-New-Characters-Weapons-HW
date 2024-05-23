using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Weapons
{
    public abstract class Weapon
    {
        public enum Rarity
        {
            common,
            uncommon,
            rare,
            epic,
            legendary
        }
        public string Name { get; protected set; }
        public int Damage { get; protected set; }
        public int Weight { get; protected set; }
        public Rarity WeaponRarity{ get;protected set; }

        public Weapon(Rarity rarity)
        {
            WeaponRarity = rarity;
            Weight = 10;
            switch (WeaponRarity)
            {
                case Rarity.common:
                    Name = "Common ";
                    Damage = 10;
                    break;
                case Rarity.uncommon:
                    Name = "Uncommon ";
                    Damage = 15;
                    break;
                case Rarity.rare:
                    Name = "Rare ";
                    Damage = 20;
                    break;
                case Rarity.epic:
                    Name = "Epic ";
                    Damage = 25;
                    break;
                case Rarity.legendary:
                    Name = "Legendary ";
                    Damage = 30;
                    break;
                default: 
                    Name = "Unknown ";
                    Damage = 999;
                    break;
            }
        }

        public virtual int AddDamage()
        {
            int damage = Damage;
            damage += WeaponBonus();
            return damage;
        }
        public abstract int WeaponBonus();
    }
}
