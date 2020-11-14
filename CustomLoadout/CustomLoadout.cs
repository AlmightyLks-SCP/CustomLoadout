using Synapse.Api.Plugin;

namespace CustomLoadout
{
    [PluginInformation(
        Author = "AlmightyLks",
        Description = "Configure role's inventories",
        Name = "CustomLoadout",
        SynapseMajor = 2,
        SynapseMinor = 0,
        SynapsePatch = 0,
        Version = "1.0.0"
        )]
    public class CustomLoadout : AbstractPlugin
    {
        [Synapse.Api.Plugin.Config(section = "CustomLoadout")]
        public static PluginConfig Config;
        public override void Load()
        {
            SynapseController.Server.Logger.Info("<CustomLoadout> Loaded");
            _ = new PluginEventHandler();
        }
    }
}
