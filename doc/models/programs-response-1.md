
# Programs Response 1

## Structure

`ProgramsResponse1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `string` | Required | - |
| `Message` | `string` | Required | - |
| `Data` | [`Data67`](../../doc/models/data-67.md) | Optional | - |

## Example (as JSON)

```json
{
  "status": "Created",
  "message": "Program created successfully",
  "data": {
    "programId": 152,
    "userId": "000018a6-0000-0000-0000-000000000000",
    "programName": "programName6",
    "programDescription": "programDescription0",
    "programThumbnail": {
      "mediaId": "00001cb0-0000-0000-0000-000000000000",
      "fileName": "fileName0",
      "filePath": "filePath4",
      "fileUrl": "fileUrl0",
      "fileSize": 20,
      "fileFormat": "fileFormat2",
      "description": "description6"
    }
  }
}
```

