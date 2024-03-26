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

            valueB = items["Beast"]["Vivid Watcher"].chaosValue + items["Beast"]["Vivid Vulture"].chaosValue + items["Beast"]["Vivid Abberarach"].chaosValue +
                items["Beast"]["Wild Bristle Matron"].chaosValue + items["Beast"]["Wild Hellion Alpha"].chaosValue + items["Beast"]["Wild Brambleback"].chaosValue +
                items["Beast"]["Primal Rhex Matriarch"].chaosValue + items["Beast"]["Primal Cystcaller"].chaosValue + items["Beast"]["Primal Crushclaw"].chaosValue;
            valueM = items["Memory"]["Einhar's Memory of Harvest Beasts"].chaosValue;
            value = valueB - valueM;
            valueS = items["UniqueMap"]["Augmented Distant Memory"].chaosValue + items["UniqueMap"]["Twisted Distant Memory"].chaosValue +
                items["UniqueMap"]["Altered Distant Memory"].chaosValue + items["UniqueMap"]["Rewritten Distant Memory"].chaosValue
                + items["UniqueMap"]["Cortex"].chaosValue;

            value = value - items["Beast"]["Primal Rhex Matriarch"].chaosValue + (.2f * valueS);



            return value;
        }
    }
}
