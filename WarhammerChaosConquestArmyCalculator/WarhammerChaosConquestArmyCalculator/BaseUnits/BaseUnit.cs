using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarhammerChaosConquestArmyCalculator.Base_Objects;

namespace WarhammerChaosConquestArmyCalculator.BaseUnits
{
    public class WarhammerUnit: Unit
    {
        public string TroopName { get; protected set; }

        public int UnitTier { get; protected set; }


        public UnitType TroopType { get; protected set; }

        public UnitAttackType AttackType { get; protected set; }

        public UnitAllegience Allegience { get; protected set; }



        public int SquadSize { get; protected set; }

        public int SquadPower { get; protected set; }

        public int MeleeAttack { get; protected set; }

        public int MeleeDamage { get; protected set; }

        public int RangedAttack { get; protected set; }

        public int RangedDamage { get; protected set; }

        public int Morale { get; protected set; }

        public int Armor { get; protected set; }

        public int Health { get; protected set; }

        public int Speed { get; protected set; }

        public int Load { get; protected set; }

        public override string ToString()
        {
            return "" + TroopName + " Tier: " + UnitTier.ToString() + " Allegience: " + Allegience;
        }
    }
}
