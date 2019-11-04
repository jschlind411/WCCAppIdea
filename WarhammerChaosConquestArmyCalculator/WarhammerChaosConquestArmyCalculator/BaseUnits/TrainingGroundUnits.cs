using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarhammerChaosConquestArmyCalculator.Base_Objects;

namespace WarhammerChaosConquestArmyCalculator.BaseUnits
{
    public static class TrainingGroundUnits
    {
        public static List<WarhammerUnit> AllTrainingGroundUnits = new List<WarhammerUnit>()
        {
            new Marauder(), new Forsaken(), new Hellcannon(), new ChaosWarriors(), new ChaosChosen()
        };
    };

    public class Marauder : WarhammerUnit
    {
        public Marauder()
        {
            TroopName = "Marauder";

            UnitTier = 1;

            AttackType = UnitAttackType.Melee;
            Allegience = UnitAllegience.Undivided;
            TroopType = UnitType.Infantry;

            SquadSize = 10;
            SquadPower = 4;
            MeleeAttack = 30;
            MeleeDamage = 300;
            RangedAttack = 22;
            RangedDamage = 300;
            Morale = 56;
            Armor = 19;
            Health = 1000;
            Speed = 6;
            Load = 20;
        }
    }

    public class Forsaken : WarhammerUnit
    {
        public Forsaken()
        {
            TroopName = "Forsaken";

            UnitTier = 2;

            AttackType = UnitAttackType.Melee;
            Allegience = UnitAllegience.Undivided;
            TroopType = UnitType.Infantry;

            SquadSize = 6;
            SquadPower = 10;
            MeleeAttack = 30;
            MeleeDamage = 600;
            RangedAttack = 0;
            RangedDamage = 0;
            Morale = 56;
            Armor = 44;
            Health = 600;
            Speed = 7;
            Load = 35;
        }
    }

    public class Hellcannon : WarhammerUnit
    {
        public Hellcannon()
        {
            TroopName = "Hellcannon";

            UnitTier = 3;

            AttackType = UnitAttackType.Ranged;
            Allegience = UnitAllegience.Undivided;
            TroopType = UnitType.Monsters;

            SquadSize = 3;
            SquadPower = 25;
            MeleeAttack = 30;
            MeleeDamage = 60;
            RangedAttack = 22;
            RangedDamage = 750;
            Morale = 40;
            Armor = 26;
            Health = 1800;
            Speed = 5;
            Load = 45;
        }
    }

    public class ChaosWarriors: WarhammerUnit
    {
        public ChaosWarriors()
        {
            TroopName = "Chaos Warriors";

            UnitTier = 3;

            AttackType = UnitAttackType.Melee;
            Allegience = UnitAllegience.Undivided;
            TroopType = UnitType.Infantry;

            SquadSize = 10;
            SquadPower = 25;
            MeleeAttack = 37;
            MeleeDamage = 1000;
            RangedAttack = 22;
            RangedDamage = 800;
            Morale = 56;
            Armor = 44;
            Health = 1000;
            Speed = 6;
            Load = 60;
        }
    }

    public class ChaosChosen: WarhammerUnit
    {
        public ChaosChosen()
        {
            TroopName = "Chaos Chosen";

            UnitTier = 4;

            AttackType = UnitAttackType.Melee;
            Allegience = UnitAllegience.Undivided;
            TroopType = UnitType.Infantry;

            SquadSize = 15;
            SquadPower = 60;
            MeleeAttack = 45;
            MeleeDamage = 1200;
            RangedAttack = 22;
            RangedDamage = 1000;
            Morale = 56;
            Armor = 50;
            Health = 1200;
            Speed = 6;
            Load = 100;
        }
    }


}
