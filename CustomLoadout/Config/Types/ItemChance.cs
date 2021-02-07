using Synapse.Config;

namespace CustomLoadout.Config.Types
{
    public sealed class ItemChance
    {
        public SerializedItem Item { get; set; }
        public float Chance { get; set; }
        public ItemChance()
        {
            Item = new SerializedItem(-1, 1, default, default, default, new UnityEngine.Vector3(1, 1, 1));
            Chance = 100.0f;
        }
        public ItemChance(SerializedItem item, float chance)
        {
            Item = item;
            Chance = chance;
        }
    }
}
