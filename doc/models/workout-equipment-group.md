
# Workout Equipment Group

## Structure

`WorkoutEquipmentGroup`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `EquipmentCode` | `string` | Optional | Unique identifier for the equipment. |
| `EquipmentName` | `string` | Optional | Name of the equipment, localized. |
| `EquipmentThumbnail` | [`MediaAsset`](../../doc/models/media-asset.md) | Optional | - |

## Example (as JSON)

```json
{
  "equipmentCode": "BARBELL",
  "equipmentName": "Barbell",
  "equipmentThumbnail": {
    "mediaId": "0000103e-0000-0000-0000-000000000000",
    "fileName": "fileName4",
    "filePath": "filePath0",
    "fileUrl": "fileUrl4",
    "fileSize": 162,
    "fileFormat": "fileFormat6",
    "description": "description0"
  }
}
```

