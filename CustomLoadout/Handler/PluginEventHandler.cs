using MEC;
using Synapse.Api.Events.SynapseEventArguments;
using Synapse.Api.Items;
using System.Linq;
using Synapse.Api.Enum;

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

                    ushort ammo5 = loadout.AmmoConfig.ReplaceAmmo ? loadout.AmmoConfig.Ammo5 : ev.Player.AmmoBox[AmmoType.Ammo556x45];
                    ushort ammo7 = loadout.AmmoConfig.ReplaceAmmo ? loadout.AmmoConfig.Ammo7 : ev.Player.AmmoBox[AmmoType.Ammo762x39];
                    ushort ammo9 = loadout.AmmoConfig.ReplaceAmmo ? loadout.AmmoConfig.Ammo9 : ev.Player.AmmoBox[AmmoType.Ammo9x19];

                    if (loadout.ReplaceDefault)
                        ev.Player.Inventory.Clear();

                    foreach (var item in loadout.Items)
                    {
                        if (UnityEngine.Random.Range(0f, 100f) <= item.Chance)
                            ev.Player.Inventory.AddItem(item.Item.Parse());

                        ev.Player.AmmoBox[AmmoType.Ammo556x45] = ammo5;
                        ev.Player.AmmoBox[AmmoType.Ammo762x39] = ammo7;
                        ev.Player.AmmoBox[AmmoType.Ammo9x19] = ammo9;
                    }
                }
            });
        }
    }
}
