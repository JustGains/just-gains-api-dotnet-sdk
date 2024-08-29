
# Equipment 1

The data returned by the operation.

## Structure

`Equipment1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `EquipmentCode` | `string` | Required | A unique identifier for the equipment.<br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `100` |
| `EquipmentName` | `string` | Optional | The name of the equipment, localized. |
| `EquipmentThumbnail` | [`MediaAsset`](../../doc/models/media-asset.md) | Optional | - |
| `EquipmentEquipmentGroups` | `List<string>` | Optional | A list of equipment groups this equipment belongs to. |

## Example (as JSON)

```json
{
  "equipmentCode": "BARBELL",
  "equipmentName": "Barbell",
  "equipmentEquipmentGroups": [
    "WEIGHTS",
    "FREE_WEIGHTS"
  ],
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

