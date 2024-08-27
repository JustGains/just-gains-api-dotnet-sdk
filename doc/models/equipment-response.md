
# Equipment Response

## Structure

`EquipmentResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `string` | Required | - |
| `Message` | `string` | Required | - |
| `Data` | [`List<Equipment>`](../../doc/models/equipment.md) | Optional | - |

## Example (as JSON)

```json
{
  "status": "OK",
  "message": "Equipment list retrieved successfully",
  "data": [
    {
      "equipmentCode": "equipmentCode4",
      "equipmentName": "equipmentName0",
      "equipmentThumbnail": "equipmentThumbnail0",
      "equipmentEquipmentGroups": [
        "equipmentEquipmentGroups5",
        "equipmentEquipmentGroups4"
      ]
    }
  ]
}
```

