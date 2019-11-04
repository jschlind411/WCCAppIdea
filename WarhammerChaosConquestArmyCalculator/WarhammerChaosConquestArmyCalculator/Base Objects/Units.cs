using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarhammerChaosConquestArmyCalculator.Base_Objects
{
    interface Unit
    {
        string TroopName { get; }

        int UnitTier { get; }

        UnitType TroopType { get; }
        UnitAttackType AttackType { get; }
        UnitAllegience Allegience { get; }

        int SquadSize { get; }
        int SquadPower { get; }
        int MeleeAttack { get; }
        int MeleeDamage { get; }
        int RangedAttack { get; }
        int RangedDamage { get; }

        int Morale { get; }
        int Armor { get; }
        int Health { get; }
        int Speed { get; }
        int Load { get; }        
    }
}
