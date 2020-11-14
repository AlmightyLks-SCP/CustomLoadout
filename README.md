# CustomLoadout

A simple SCP SL [Synapse](https://github.com/SynapseSL/Synapse/) Plugin for custom loadouts  

---
### Configs

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
}
```
