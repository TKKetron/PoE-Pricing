using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE_Pricing
{
    internal static class Globals
    {
        public const string LEAGUE = "Affliction";
        public static float DivineValue;
        public static readonly string[] TYPES =
        {

            "Currency",
            "Fragment",
            "Tattoo",
            "Omen",
            "DivinationCard",
            "Artifact",
            "Oil",
            "Incubator",
            "UniqueWeapon",
            "UniqueArmour",
            "UniqueAccessory",
            "UniqueFlask",
            "UniqueRelic",
            "UniqueJewel",
            "SkillGem",
            "ClusterJewel",
            "Map",
            "BlightedMap",
            "BlightRavagedMap",
            "UniqueMap",
            "DeliriumOrb",
            "Scarab",
            "Memory",
            "BaseType",
            "Fossil",
            "Resonator",
            "Beast",
            "Essence",
            "Vial"
        };

        public static Dictionary<string, Dictionary<string, Item>> items = new Dictionary<string, Dictionary<string, Item>>();

        public class Item : IComparable<Item>
        {
            public int id { get; set; }
            public string currencyTypeName { get; set; }
            public string name { get; set; }
            public string icon { get; set; }
            public string baseType { get; set; }
            public int ItemClass { get; set; }
            public float chaosValue { get; set; }
            public float chaosEquivalent { get; set; }
            public float exaltedValue { get; set; }
            public float divineValue { get; set; }
            public float listingCount { get; set; }

            public int CompareTo(Item other)
            {
                // Compare items based on their chaosValue
                return -1 * this.chaosValue.CompareTo(other.chaosValue);
            }
        }
    }
}
