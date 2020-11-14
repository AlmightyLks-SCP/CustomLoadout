using CustomLoadout.Config;
using System.Collections.Generic;
using System.ComponentModel;

namespace CustomLoadout
{
    public class Loadout
    {
        [Description("Affected role")]
        public int RoleID { get; set; }

        [Description("Replace the role's default inventory")]
        public bool ReplaceDefault { get; set; }

        [Description("Items & their Chance to spawn")]
        public List<ItemChance> Items { get; set; }
        public Loadout()
        {
            RoleID = -1;
            ReplaceDefault = false;
            Items = new List<ItemChance>() { new ItemChance() };
        }
    }
}
