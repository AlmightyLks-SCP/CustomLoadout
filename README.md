# OUTDATED
This Plugin was intended for Synapse 2, and is not made, nor compatible with Synapse3.

---


# CustomLoadout

A simple SCP SL [Synapse](https://github.com/SynapseSL/Synapse/) Plugin for custom loadouts  

---
### Configs

For base-game role and item ids, checkout [DefaultRoleIDs](DefaultRoleIDs.md) & [DefaultItemIDs](DefaultItemIDs.md)

Default config:

```yaml
[CustomLoadout]
{
# Loadout configuration
roleInventory:
-
# Affected role
  roleID: -1
  # Replace the role's default inventory
  replaceDefault: false
  # Items & their Chance to spawn
  items:
  - item:
      iD: -1
      durabillity: 1
      sight: 0
      barrel: 0
      other: 0
      xSize: 1
      ySize: 1
      zSize: 1
    chance: 100
  # Configure the class' ammunition
  ammoConfig:
  # Should the class' amount of ammo be replaced?
    replaceAmmo: false
    ammo5: 0
    ammo7: 0
    ammo9: 0
}
```

---

To add another custom loadout for a role, copy and paste

```yaml
-
# Affected role
  roleID: -1
  # Replace the role's default inventory
  replaceDefault: false
  # Items & their Chance to spawn
  items:
  - item:
      iD: -1
      durabillity: 1
      sight: 0
      barrel: 0
      other: 0
      xSize: 1
      ySize: 1
      zSize: 1
    chance: 100
```

one after the other within the `roleInventory` list.

---

For up to 8 custom loadout-items, just copy and paste
```yaml
  - item:
      iD: -1
      durabillity: 1
      sight: 0
      barrel: 0
      other: 0
      xSize: 1
      ySize: 1
      zSize: 1
    chance: 100
```
within the `items` list inside of your target role.
