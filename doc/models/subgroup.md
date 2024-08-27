
# Subgroup

## Structure

`Subgroup`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `EquipmentGroupCode` | `string` | Optional | Unique identifier for the equipment group. |
| `EquipmentGroupName` | `string` | Optional | The localized name of the equipment group<br>**Constraints**: *Pattern*: `^[a-zA-Z0-9_]*$` |
| `EquipmentGroupType` | [`EquipmentGroupTypeEnum?`](../../doc/models/equipment-group-type-enum.md) | Optional | - |
| `EquipmentGroupParent` | `string` | Optional | parent group CODE for hierarchical structuring. |

## Example (as JSON)

```json
{
  "equipmentGroupCode": "DUMBBELLS",
  "equipmentGroupName": "Dumbbells",
  "equipmentGroupParent": "FREE_WEIGHTS",
  "equipmentGroupType": "main_group"
}
```

