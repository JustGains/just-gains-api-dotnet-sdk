
# Data 43

## Structure

`Data43`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `EquipmentCode` | `string` | Optional | A unique identifier for the equipment.<br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `100` |
| `EquipmentName` | `string` | Optional | The name of the equipment, localized. |
| `EquipmentThumbnail` | `string` | Optional | An optional thumbnail image representing the equipment. |
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
  "equipmentThumbnail": "equipmentThumbnail4"
}
```

