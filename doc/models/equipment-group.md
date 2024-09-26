
# Equipment Group

## Structure

`EquipmentGroup`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `EquipmentGroupCode` | `string` | Optional | Unique identifier for the equipment group. |
| `EquipmentGroupName` | `string` | Optional | Name of the equipment group, localized. |
| `EquipmentGroupParent` | `string` | Optional | parent group CODE for hierarchical structuring. |
| `EquipmentGroupEquipment` | `List<string>` | Optional | - |
| `EquipmentGroupThumbnail` | [`MediaAsset`](../../doc/models/media-asset.md) | Optional | - |
| `SortOrder` | `int?` | Optional | Used to sort the equipment groups<br>**Default**: `0` |

## Example (as JSON)

```json
{
  "equipmentGroupCode": "DUMBBELLS",
  "equipmentGroupName": "Dumbbells",
  "equipmentGroupParent": "FREE_WEIGHTS",
  "sortOrder": 0,
  "equipmentGroupEquipment": [
    "equipmentGroupEquipment9"
  ],
  "equipmentGroupThumbnail": {
    "mediaId": "00000372-0000-0000-0000-000000000000",
    "fileName": "fileName8",
    "filePath": "filePath6",
    "fileUrl": "fileUrl8",
    "fileSize": 182,
    "fileFormat": "fileFormat0",
    "description": "description4"
  }
}
```

