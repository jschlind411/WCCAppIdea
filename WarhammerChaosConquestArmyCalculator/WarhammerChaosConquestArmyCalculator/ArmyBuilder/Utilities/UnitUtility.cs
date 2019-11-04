using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarhammerChaosConquestArmyCalculator.Base_Objects;

namespace WarhammerChaosConquestArmyCalculator.ArmyBuilder.Utilities
{
    public static class UnitUtility
    {
        public static List<UnitType> TopUnitTypes(List<UnitMarch> March)
        {
            List<SortTopUnits> typesToSort = new List<SortTopUnits>();
            List<UnitType> TopTypes = new List<UnitType>();

            for (int i = 0; i < March.Count(); i++)
            {
                var unitInMarch = March[i];

                if (unitInMarch.Quantity > 0)
                {
                    bool isInList = false;

                    foreach (SortTopUnits unitInQuestion in typesToSort)
                    {
                        if (unitInQuestion.Types == unitInMarch.Unit.TroopType)
                        {
                            unitInQuestion.NumTimes++;
                            isInList = true;
                        }
                    }

                    if (isInList == false)
                    {
                        typesToSort.Add(new SortTopUnits()
                        {
                            Types = unitInMarch.Unit.TroopType,
                            NumTimes = 1
                        });
                    }
                }
            }

            bool isNotSorted = true;
            int index = 0;
            SortTopUnits unit = null;

            do
            {

                foreach (SortTopUnits unitToCheck in typesToSort)
                {

                    if (unit == null)
                    {
                        unit = unitToCheck;
                    }

                    if (unitToCheck.NumTimes > unit.NumTimes)
                    {
                        unit = unitToCheck;
                    }
                }

                TopTypes.Add(unit.Types);
                typesToSort.Remove(unit);

                if (typesToSort.Count > 0)
                {
                    unit = null;
                }
                else
                {
                    isNotSorted = false;
                }


            } while (isNotSorted);

            return TopTypes;
        }

        protected class SortTopUnits
        {
            public UnitType Types { get; set; }
            public int NumTimes { get; set; }
        }

        public static int CalculateSpecificUnitPowerValue(UnitMarch unitToCalculate, List<UnitMarch> March)
        {
            foreach (UnitMarch unit in March)
            {
                if (unit.Unit.TroopName == unitToCalculate.Unit.TroopName)
                {
                    return unit.Unit.SquadPower * unitToCalculate.Quantity;
                }
            }

            return 0;
        }

        public static int CalculateMarchPower(List<UnitMarch> March)
        {
            int power = 0;

            foreach (UnitMarch unit in March)
            {
                if (unit.Quantity != 0)
                {
                    power += unit.Unit.SquadPower * unit.Quantity;
                }
            }

            return power;
        }

        public static RangedVSMelee CalculateRangeVSMelee(List<UnitMarch> March)
        {
            var rvm = new RangedVSMelee();

            foreach(UnitMarch unitInMarch in March)
            {
                if(unitInMarch.Quantity > 0)
                {
                    if(unitInMarch.Unit.AttackType == UnitAttackType.Ranged)
                    {
                        rvm.Ranged.Add(unitInMarch);
                    }

                    else if (unitInMarch.Unit.AttackType == UnitAttackType.Melee)
                    {
                        rvm.Melee.Add(unitInMarch);
                    }
                }
            }

            rvm.CalculatePercentage();

            return rvm;
        }
    }

    public class RangedVSMelee
    {
        public List<UnitMarch> Ranged = new List<UnitMarch>();
        public List<UnitMarch> Melee = new List<UnitMarch>();

        public float percentageRanged;
        public float percentageMelee;

        public void CalculatePercentage()
        {
            float numUnitsMelee = 0;
            float numUnitsRanged = 0;

            foreach(UnitMarch unitInMarch in Ranged)
            {
                numUnitsRanged += unitInMarch.Quantity;
            }

            foreach(UnitMarch unitInMarch in Melee)
            {
                numUnitsMelee += unitInMarch.Quantity;
            }

            float total = numUnitsMelee + numUnitsRanged;

            percentageRanged = (numUnitsRanged / total) * 100;
            percentageMelee = (numUnitsMelee / total) * 100;
        }

    }
}
