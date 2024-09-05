
# Equipment List Response

## Structure

`EquipmentListResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `string` | Required | The status of the response, corresponding to standard HTTP status codes. |
| `Message` | `string` | Required | A human-readable message describing the result of the operation. |
| `Data` | [`List<Equipment>`](../../doc/models/equipment.md) | Required | - |

## Example (as JSON)

```json
{
  "status": "OK",
  "message": "Operation completed successfully.",
  "data": [
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
  ]
}
```

