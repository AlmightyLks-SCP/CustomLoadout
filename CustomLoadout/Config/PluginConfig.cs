using Synapse.Config;
using System.Collections.Generic;
using System.ComponentModel;

namespace CustomLoadout
{
    public class PluginConfig : AbstractConfigSection
    {
        [Description("Loadout configuration")]
        public List<Loadout> RoleInventory { get; set; } = new List<Loadout>()
        {
            new Loadout()
        };
    }
}