using CustomLoadout.Config;
using System.Collections.Generic;
using System.ComponentModel;

namespace CustomLoadout.Config.Types
{
    public sealed class Loadout
    {
        public int RoleID { get; set; }

        [Description("Replace the role's default inventory")]
        public bool ReplaceDefault { get; set; }

        [Description("Items & their Chance to spawn")]
        public List<ItemChance> Items { get; set; }

        [Description("Configure the class' ammunition")]
        public AmmoConfig AmmoConfig { get; set; }

        public Loadout()
        {
            RoleID = -1;
            ReplaceDefault = false;
            Items = new List<ItemChance>() { new ItemChance() };
            AmmoConfig = new AmmoConfig();
        }
    }
}
