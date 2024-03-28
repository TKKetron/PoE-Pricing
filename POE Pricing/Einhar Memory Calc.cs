using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static POE_Pricing.Globals;

namespace POE_Pricing
{
    internal static class Einhar_Memory_Calc
    {
        public static double GetMemoryValue()
        {
            float valueB, valueM, valueS, value;

            valueB = itemsByName["Beast"]["Vivid Watcher"].chaosValue + itemsByName["Beast"]["Vivid Vulture"].chaosValue + itemsByName["Beast"]["Vivid Abberarach"].chaosValue +
                itemsByName["Beast"]["Wild Bristle Matron"].chaosValue + itemsByName["Beast"]["Wild Hellion Alpha"].chaosValue + itemsByName["Beast"]["Wild Brambleback"].chaosValue +
                itemsByName["Beast"]["Primal Rhex Matriarch"].chaosValue + itemsByName["Beast"]["Primal Cystcaller"].chaosValue + itemsByName["Beast"]["Primal Crushclaw"].chaosValue;
            valueM = itemsByName["Memory"]["Einhar's Memory of Harvest Beasts"].chaosValue;
            value = valueB - valueM;
            valueS = itemsByName["UniqueMap"]["Augmented Distant Memory"].chaosValue + itemsByName["UniqueMap"]["Twisted Distant Memory"].chaosValue +
                itemsByName["UniqueMap"]["Altered Distant Memory"].chaosValue + itemsByName["UniqueMap"]["Rewritten Distant Memory"].chaosValue
                + itemsByName["UniqueMap"]["Cortex"].chaosValue;

            value = value - itemsByName["Beast"]["Primal Rhex Matriarch"].chaosValue + (.2f * valueS);



            return value;
        }
    }
}
