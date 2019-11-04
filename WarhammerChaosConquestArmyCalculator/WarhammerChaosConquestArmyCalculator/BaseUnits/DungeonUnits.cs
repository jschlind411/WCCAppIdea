using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarhammerChaosConquestArmyCalculator.Base_Objects;

namespace WarhammerChaosConquestArmyCalculator.BaseUnits
{

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

    public static class DungeonUnits
    {
        public static List<WarhammerUnit> AllDungeonUnits = new List<WarhammerUnit>()
        {
            new ChaosSpawn(), new ChaosOgres(), new MutalithVortexBeasts(), new DragonOgres(), new ChaosTrolls() 
        };
    };

    public class ChaosSpawn : WarhammerUnit
    {
        public ChaosSpawn()
        {
            TroopName = "Chaos Spawn";

            UnitTier = 2;

            AttackType = UnitAttackType.Melee;
            Allegience = UnitAllegience.Undivided;
            TroopType = UnitType.MonstrousBeasts;

            SquadSize = 3;
            SquadPower = 10;
            MeleeAttack = 22;
            MeleeDamage = 360;
            RangedAttack = 0;
            RangedDamage = 0;
            Morale = 80;
            Armor = 32;
            Health = 900;
            Speed = 7;
            Load = 35;
        }
    }

    public class ChaosOgres : WarhammerUnit
    {
        public ChaosOgres()
        {
            TroopName = "Chaos Ogres";

            UnitTier = 3;

            AttackType = UnitAttackType.Ranged;
            Allegience = UnitAllegience.Undivided;
            TroopType = UnitType.MonstrousInfantry;

            SquadSize = 6;
            SquadPower = 25;
            MeleeAttack = 22;
            MeleeDamage = 600;
            RangedAttack = 22;
            RangedDamage = 720;
            Morale = 48;
            Armor = 38;
            Health = 1500;
            Speed = 7;
            Load = 70;
        }
    }

    public class SlaughterBrutes : WarhammerUnit
    {
        public SlaughterBrutes()
        {
            TroopName = "Slaughter Brutes";

            UnitTier = 3;

            AttackType = UnitAttackType.Melee;
            Allegience = UnitAllegience.Undivided;
            TroopType = UnitType.MonstrousBeasts;

            SquadSize = 2;
            SquadPower = 25;
            MeleeAttack = 22;
            MeleeDamage = 560;
            RangedAttack = 0;
            RangedDamage = 0;
            Morale = 40;
            Armor = 50;
            Health = 1000;
            Speed = 7;
            Load = 50;
        }
    }
    public class MutalithVortexBeasts : WarhammerUnit
    {
        public MutalithVortexBeasts()
        {
            TroopName = "Mutalith Vortex Beasts";

            UnitTier = 4;

            AttackType = UnitAttackType.Melee;
            Allegience = UnitAllegience.Undivided;
            TroopType = UnitType.Monsters;

            SquadSize = 3;
            SquadPower = 60;
            MeleeAttack = 22;
            MeleeDamage = 600;
            RangedAttack = 0;
            RangedDamage = 0;
            Morale = 64;
            Armor = 50;
            Health = 1500;
            Speed = 7;
            Load = 90;
        }
    }

    public class DragonOgres : WarhammerUnit
    {
        public DragonOgres()
        {
            TroopName = "Dragon Ogres";

            UnitTier = 4;

            AttackType = UnitAttackType.Melee;
            Allegience = UnitAllegience.Undivided;
            TroopType = UnitType.MonstrousBeasts;

            SquadSize = 5;
            SquadPower = 60;
            MeleeAttack = 30;
            MeleeDamage = 750;
            RangedAttack = 0;
            RangedDamage = 0;
            Morale = 64;
            Armor = 38;
            Health = 2000;
            Speed = 8;
            Load = 100;
        }
    }

    public class ChaosTrolls : WarhammerUnit
    {
        public ChaosTrolls()
        {
            TroopName = "Chaos Trolls";

            UnitTier = 4;

            AttackType = UnitAttackType.Melee;
            Allegience = UnitAllegience.Undivided;
            TroopType = UnitType.MonstrousInfantry;

            SquadSize = 8;
            SquadPower = 60;
            MeleeAttack = 22;
            MeleeDamage = 1200;
            RangedAttack = 7;
            RangedDamage = 1200;
            Morale = 32;
            Armor = 26;
            Health = 2400;
            Speed = 7;
            Load = 120;
        }
    }
}

