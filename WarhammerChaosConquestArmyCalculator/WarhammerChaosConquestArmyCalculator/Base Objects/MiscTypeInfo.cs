using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarhammerChaosConquestArmyCalculator.Base_Objects
{
    public enum UnitAttackType
    {
        Melee = 0,
        Ranged = 1
    }

    public enum UnitType
    {
        Infantry = 0,
        MonstrousInfantry = 1,
        Cavalry = 2,
        MonstrousCavalry = 3,
        Chariots = 4, 
        Monsters = 5,
        MonstrousBeasts = 6,
        WarBeasts = 7
    }

    public enum UnitAllegience
    {
        Undivided = 0,
        Khorne = 1,
        Tzeentch = 2,
        Nurgle = 3,
        Slaanesh = 4
    }

}
