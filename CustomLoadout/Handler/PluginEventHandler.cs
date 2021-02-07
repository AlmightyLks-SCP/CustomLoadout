using MEC;
using Synapse.Api.Events.SynapseEventArguments;
using Synapse.Api.Items;
using System.Linq;

namespace CustomLoadout
{
    internal class PluginEventHandler
    {
        public PluginEventHandler()
            => Synapse.Api.Events.EventHandler.Get.Player.PlayerSetClassEvent += Player_PlayerSetClassEvent;
        private void Player_PlayerSetClassEvent(PlayerSetClassEventArgs ev)
        {
            Timing.CallDelayed(0.01f, () =>
            {
                if (CustomLoadout.Config.RoleInventory.Any((_) => _.RoleID == ev.Player.RoleID))
                {
                    var loadout = CustomLoadout.Config.RoleInventory.FirstOrDefault((_) => _.RoleID == ev.Player.RoleID);
                    if (loadout is null)
                        return;

                    uint ammo5 = loadout.AmmoConfig.ReplaceAmmo ? loadout.AmmoConfig.Ammo5 : ev.Player.Ammo5;
                    uint ammo7 = loadout.AmmoConfig.ReplaceAmmo ? loadout.AmmoConfig.Ammo7 : ev.Player.Ammo7;
                    uint ammo9 = loadout.AmmoConfig.ReplaceAmmo ? loadout.AmmoConfig.Ammo9 : ev.Player.Ammo9;

                    if (loadout.ReplaceDefault)
                        ev.Player.Inventory.Clear();

                    foreach (var item in loadout.Items)
                    {
                        if (UnityEngine.Random.Range(0f, 100f) <= item.Chance)
                            ev.Player.Inventory.AddItem(item.Item.Parse());

                        ev.Player.Ammo5 = ammo5;
                        ev.Player.Ammo7 = ammo7;
                        ev.Player.Ammo9 = ammo9;
                    }
                }
            });
        }
    }
}
