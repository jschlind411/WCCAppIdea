using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarhammerChaosConquestArmyCalculator.ArmyBuilder;

namespace WarhammerChaosConquestArmyCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            MarchBuilder builder = new MarchBuilder();

            //foreach (UnitMarch unit in builder.March)
            //{
            //    Console.WriteLine(unit.Unit.ToString());

            //    Console.WriteLine();
            //}

            foreach(UnitMarch unit in builder.March)
            {
                if(unit.Unit.TroopName == "Chaos Trolls")
                {
                    unit.Quantity = 5000;
                }

                if (unit.Unit.TroopName == "Chaos Ogres")
                {
                    unit.Quantity = 10000;
                }

                if (unit.Unit.TroopName == "Chaos Warriors")
                {
                    unit.Quantity = 10000;
                }

                if (unit.Unit.TroopName == "Forsaken")
                {
                    unit.Quantity = 10000;
                }

                if (unit.Unit.TroopName == "Chaos Chosen")
                {
                    unit.Quantity = 10000;
                }

                if (unit.Unit.TroopName == "Hellcannon")
                {
                    unit.Quantity = 10000;
                }
                //Skullcrusher Of Khorne
                if (unit.Unit.TroopName == "Skullcrusher of Khorne")
                {
                    unit.Quantity = 1;
                }
            }

            //builder.March[2].Quantity = 500;
            //builder.March[1].Quantity = 1000;

            foreach(UnitMarch unit in builder.March)
            {
                if(unit.Quantity > 0)
                {
                    Console.WriteLine(unit.Quantity + " units of " + unit.Unit.TroopName + " = " + builder.SpecificUnitPower(unit) + " Power");
                    Console.WriteLine();
                }
            }

            Console.WriteLine("Total Unit Power = " + builder.TotalMarchPower);

            Console.WriteLine();

            var topUnits = builder.TopUnitTypes;

            Console.WriteLine("Most Used Unit Types: \n" +
                "#1: " + topUnits[0] + "\n" + 
                "#2: " + topUnits[1] + "\n" +
                "#3: " + topUnits[2]);

            var topAllegiences = builder.TopAllegiences;

            Console.WriteLine();

            Console.WriteLine("Most Used Unit Types: \n" +
                "#1: " + topAllegiences[0] + "\n" +
                "#2: " + topAllegiences[1] + "\n" //+
                //"#3: " + topAllegiences[2]
                );

            Console.WriteLine();

            var rvm = builder.RangedVSMeleeInfo;

            Console.WriteLine("Total Percent Ranged: " + rvm.percentageRanged);
            Console.WriteLine("Total Percentage Melee: " + rvm.percentageMelee);

            Console.ReadKey();
        }
    }
}
