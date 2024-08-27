
# Equipment Groups Response 1

## Structure

`EquipmentGroupsResponse1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `string` | Required | - |
| `Message` | `string` | Required | - |
| `Data` | [`EquipmentGroup`](../../doc/models/equipment-group.md) | Optional | - |

## Example (as JSON)

```json
{
  "status": "Created",
  "message": "Equipment group created successfully",
  "data": {
    "equipmentGroupCode": "equipmentGroupCode2",
    "equipmentGroupName": "equipmentGroupName6",
    "equipmentGroupParent": "equipmentGroupParent4",
    "equipmentGroupEquipment": [
      "equipmentGroupEquipment5",
      "equipmentGroupEquipment6",
      "equipmentGroupEquipment7"
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
}
```

