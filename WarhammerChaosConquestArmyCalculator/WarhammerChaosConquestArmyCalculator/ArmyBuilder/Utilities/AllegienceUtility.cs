using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarhammerChaosConquestArmyCalculator.Base_Objects;

namespace WarhammerChaosConquestArmyCalculator.ArmyBuilder.Utilities
{
    public static class AllegienceUtility
    {

        public static List<UnitAllegience> TopAllegiences(List<UnitMarch> March)
        {
            List<SortTopAllegience> typesToSort = new List<SortTopAllegience>();
            List<UnitAllegience> TopTypes = new List<UnitAllegience>();

            for (int i = 0; i < March.Count(); i++)
            {
                var unitInMarch = March[i];

                if (unitInMarch.Quantity > 0)
                {
                    bool isInList = false;

                    foreach (SortTopAllegience unitInQuestion in typesToSort)
                    {
                        if (unitInQuestion.Allegience == unitInMarch.Unit.Allegience)
                        {
                            unitInQuestion.NumTimes++;
                            isInList = true;
                        }
                    }

                    if (isInList == false)
                    {
                        typesToSort.Add(new SortTopAllegience()
                        {
                            Allegience = unitInMarch.Unit.Allegience,
                            NumTimes = 1
                        });
                    }
                }
            }

            bool isNotSorted = true;
            int index = 0;
            SortTopAllegience unit = null;

            do
            {

                foreach (SortTopAllegience unitToCheck in typesToSort)
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

                TopTypes.Add(unit.Allegience);
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

        protected class SortTopAllegience
        {
            public UnitAllegience Allegience { get; set; }
            public int NumTimes { get; set; }
        }
    }
}
