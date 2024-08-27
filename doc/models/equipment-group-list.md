
# Equipment Group List

## Structure

`EquipmentGroupList`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `EquipmentGroupCode` | `string` | Optional | Unique identifier for the equipment group. |
| `EquipmentGroupName` | `string` | Optional | The localized name of the equipment group<br>**Constraints**: *Pattern*: `^[a-zA-Z0-9_]*$` |
| `EquipmentGroupType` | [`EquipmentGroupTypeEnum?`](../../doc/models/equipment-group-type-enum.md) | Optional | - |
| `EquipmentGroupParent` | `string` | Optional | parent group CODE for hierarchical structuring. |
| `Subgroups` | [`List<Subgroup>`](../../doc/models/subgroup.md) | Optional | - |
| `EquipmentGroupEquipment` | `List<string>` | Optional | - |
| `EquipmentThumbnail` | [`MediaAsset`](../../doc/models/media-asset.md) | Optional | - |
| `SortOrder` | `int?` | Optional | Used to sort the equipment groups<br>**Default**: `0` |

## Example (as JSON)

```json
{
  "equipmentGroupCode": "DUMBBELLS",
  "equipmentGroupName": "Dumbbells",
  "equipmentGroupParent": "FREE_WEIGHTS",
  "equipmentGroupEquipment": [
    "WEIGHTS",
    "FREE_WEIGHTS"
  ],
  "sortOrder": 0,
  "equipmentGroupType": "exercise_group",
  "subgroups": [
    {
      "equipmentGroupCode": "equipmentGroupCode4",
      "equipmentGroupName": "equipmentGroupName8",
      "equipmentGroupType": "exercise_group",
      "equipmentGroupParent": "equipmentGroupParent6"
    }
  ]
}
```

