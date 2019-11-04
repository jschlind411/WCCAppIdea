using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarhammerChaosConquestArmyCalculator.ArmyBuilder.Utilities;
using WarhammerChaosConquestArmyCalculator.Base_Objects;
using WarhammerChaosConquestArmyCalculator.BaseUnits;

namespace WarhammerChaosConquestArmyCalculator.ArmyBuilder
{
    public class UnitMarch
    {
        public WarhammerUnit Unit;
        public int Quantity;
    }

    public class MarchBuilder
    {
        public List<UnitMarch> March = new List<UnitMarch>();

        public MarchBuilder()
        {
            PopulateBaseList();
        }

        private void PopulateBaseList()
        {
            foreach (WarhammerUnit unit in TrainingGroundUnits.AllTrainingGroundUnits)
            {
                UnitMarch trainingGroundTroop = new UnitMarch()
                {
                    Unit = unit,
                    Quantity = 0
                };

                March.Add(trainingGroundTroop);
            }

            foreach (WarhammerUnit unit in BestiaryUnits.AllBestiaryUnits)
            {
                UnitMarch bestiaryTroop = new UnitMarch()
                {
                    Unit = unit,
                    Quantity = 0
                };

                March.Add(bestiaryTroop);
            }

            foreach (WarhammerUnit unit in DungeonUnits.AllDungeonUnits)
            {
                UnitMarch dungeonUnit = new UnitMarch()
                {
                    Unit = unit,
                    Quantity = 0
                };

                March.Add(dungeonUnit);
            }
        }

        #region MarchInformation

        public int TotalMarchPower
        {
            get
            {
                return UnitUtility.CalculateMarchPower(March);
            }
        }

        public int SpecificUnitPower(UnitMarch unit)
        {
            return UnitUtility.CalculateSpecificUnitPowerValue(unit, March);
        }

        public List<UnitAllegience> TopAllegiences
        {
            get
            {
                return AllegienceUtility.TopAllegiences(March);
            }
        }

        public List<UnitType> TopUnitTypes
        {
            get
            {
                return UnitUtility.TopUnitTypes(March);
            }
        }

        public RangedVSMelee RangedVSMeleeInfo
        {
            get
            {
                return UnitUtility.CalculateRangeVSMelee(March);
            }
        }

        #endregion



    }
}
