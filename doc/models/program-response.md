
# Program Response

## Structure

`ProgramResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `string` | Required | The status of the response, corresponding to standard HTTP status codes. |
| `Message` | `string` | Required | A human-readable message describing the result of the operation. |
| `Data` | [`Program1`](../../doc/models/program-1.md) | Required | The data returned by the operation. |

## Example (as JSON)

```json
{
  "status": "OK",
  "message": "Operation completed successfully.",
  "data": {
    "programId": 1001,
    "userId": "123e4567-e89b-12d3-a456-426614174000",
    "programName": "12-Week Strength Builder",
    "programDescription": "A comprehensive strength training program designed for intermediate lifters looking to increase their overall strength in major compound lifts.",
    "publishStatusCode": "PUBLISHED",
    "createdAt": "07/01/2023 09:00:00",
    "updatedAt": "07/15/2023 14:30:00",
    "deletedAt": "08/01/2023 10:00:00",
    "deletedBy": "987e6543-e21b-12d3-a456-426614174000",
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

