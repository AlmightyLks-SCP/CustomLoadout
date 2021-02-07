using Synapse.Api.Plugin;

namespace CustomLoadout
{
    [PluginInformation(
        Author = "AlmightyLks",
        Description = "Configure roles' inventories",
        Name = "CustomLoadout",
        LoadPriority = int.MinValue,
        SynapseMajor = 2,
        SynapseMinor = 1,
        SynapsePatch = 0,
        Version = "1.1.0"
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
