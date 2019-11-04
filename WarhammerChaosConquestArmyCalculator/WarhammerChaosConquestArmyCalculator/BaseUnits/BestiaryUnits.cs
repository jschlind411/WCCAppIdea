using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarhammerChaosConquestArmyCalculator.Base_Objects;

namespace WarhammerChaosConquestArmyCalculator.BaseUnits
{
    public static class BestiaryUnits
    {
        public static List<WarhammerUnit> AllBestiaryUnits = new List<WarhammerUnit>()
        {
            new ChaosWarhounds(), new MarauderHorsemen(), new ChaosChariot(), new ChaosGiants(), new GoreBeastChariots(), new ChaosKnight(), new Chimera(), new SkullCrusherOfKhorne()
        };
    };
    /*
TroopName = ;

UnitTier = ;

AttackType = UnitAttackType.;
Allegience = UnitAllegience.;
TroopType = UnitType.;

SquadSize = ;
SquadPower = ;
MeleeAttack = ;
MeleeDamage = ;
RangedAttack = ;
RangedDamage = ;
Morale = ;
Armor = ;
Health = ;
Speed = ;
Load = ;      
*/

    public class ChaosWarhounds : WarhammerUnit
    {
        public ChaosWarhounds()
        {
            TroopName = "Chaos Warhounds";

            UnitTier = 1;

            AttackType = UnitAttackType.Melee;
            Allegience = UnitAllegience.Undivided;
            TroopType = UnitType.WarBeasts;

            SquadSize = 10;
            SquadPower = 4;
            MeleeAttack = 30;
            MeleeDamage = 300;
            RangedAttack = 0;
            RangedDamage = 0;
            Morale = 40;
            Armor = 19;
            Health = 1000;
            Speed = 8;
            Load = 15;
        }
    }

    public class MarauderHorsemen : WarhammerUnit
    {
        public MarauderHorsemen()
        {
            TroopName = "Marauder Horsemen";

            UnitTier = 2;

            AttackType = UnitAttackType.Melee;
            Allegience = UnitAllegience.Undivided;
            TroopType = UnitType.Cavalry;

            SquadSize = 8;
            SquadPower = 10;
            MeleeAttack = 30;
            MeleeDamage = 480;
            RangedAttack = 22;
            RangedDamage = 240;
            Morale = 48;
            Armor = 19;
            Health = 1600;
            Speed = 8;
            Load = 40;
        }
    }

    public class ChaosChariot : WarhammerUnit
    {
        public ChaosChariot()
        {
            TroopName = "Chaos Chariot";

            UnitTier = 2;

            AttackType = UnitAttackType.Ranged;
            Allegience = UnitAllegience.Undivided;
            TroopType = UnitType.Chariots;

            SquadSize = 8;
            SquadPower = 10;
            MeleeAttack = 37;
            MeleeDamage = 240;
            RangedAttack = 22;
            RangedDamage = 300;
            Morale = 52;
            Armor = 56;
            Health = 1000;
            Speed = 8;
            Load = 45;
        }
    }

    public class ChaosGiants : WarhammerUnit
    {
        public ChaosGiants()
        {
            TroopName = "Chaos Giants";

            UnitTier = 3;

            AttackType = UnitAttackType.Melee;
            Allegience = UnitAllegience.Undivided;
            TroopType = UnitType.MonstrousBeasts;

            SquadSize = 3;
            SquadPower = 25;
            MeleeAttack = 22;
            MeleeDamage = 520;
            RangedAttack = 22;
            RangedDamage = 360;
            Morale = 80;
            Armor = 32;
            Health = 1800;
            Speed = 7;
            Load = 60;
        }
    }

    public class GoreBeastChariots : WarhammerUnit
    {
        public GoreBeastChariots()
        {
            TroopName = "Gorebeast Chariot";

            UnitTier = 4;

            AttackType = UnitAttackType.Ranged;
            Allegience = UnitAllegience.Undivided;
            TroopType = UnitType.Chariots;

            SquadSize = 3;
            SquadPower = 60;
            MeleeAttack = 37;
            MeleeDamage = 300;
            RangedAttack = 29;
            RangedDamage = 450;
            Morale = 52;
            Armor = 63;
            Health = 1500;
            Speed = 7;
            Load = 120;
        }
    }

    public class ChaosKnight : WarhammerUnit
    {
        public ChaosKnight()
        {
            TroopName = "Chaos Knight";

            UnitTier = 4;

            AttackType = UnitAttackType.Melee;
            Allegience = UnitAllegience.Undivided;
            TroopType = UnitType.Cavalry;

            SquadSize = 8;
            SquadPower = 60;
            MeleeAttack = 37;
            MeleeDamage = 960;
            RangedAttack = 22;
            RangedDamage = 640;
            Morale = 56;
            Armor = 50;
            Health = 1600;
            Speed = 8;
            Load = 110;
        }
    }

    public class Chimera : WarhammerUnit
    {
        public Chimera()
        {
            TroopName = "Chimera";

            UnitTier = 4;

            AttackType = UnitAttackType.Melee;
            Allegience = UnitAllegience.Undivided;
            TroopType = UnitType.Monsters;

            SquadSize = 3;
            SquadPower = 60;
            MeleeAttack = 30;
            MeleeDamage = 980;
            RangedAttack = 37;
            RangedDamage = 500;
            Morale = 40;
            Armor = 50;
            Health = 1200;
            Speed = 8;
            Load = 80;
        }
    }

    public class SkullCrusherOfKhorne : WarhammerUnit
    {
        public SkullCrusherOfKhorne()
        {
            TroopName = "Skullcrusher of Khorne";

            UnitTier = 5;

            AttackType = UnitAttackType.Melee;
            Allegience = UnitAllegience.Khorne;
            TroopType = UnitType.MonstrousCavalry;

            SquadSize = 4;
            SquadPower = 150;
            MeleeAttack = 37;
            MeleeDamage = 1000;
            RangedAttack = 22;
            RangedDamage = 320;
            Morale = 64;
            Armor = 50;
            Health = 2000;
            Speed = 8;
            Load = 200;
        }
    }
}

