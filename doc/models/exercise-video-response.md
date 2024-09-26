
# Exercise Video Response

## Structure

`ExerciseVideoResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `string` | Required | The status of the response, corresponding to standard HTTP status codes. |
| `Message` | `string` | Required | A human-readable message describing the result of the operation. |
| `Data` | [`ExerciseVideo`](../../doc/models/exercise-video.md) | Required | - |

## Example (as JSON)

```json
{
  "status": "OK",
  "message": "Operation completed successfully.",
  "data": {
    "exerciseCode": "BARBELL_SQUAT",
    "creatorProfileId": "9fdd12f5-c7b9-82a8-f6cc-cceac14c13c1",
    "userName": "john_doe",
    "sortOrder": 1,
    "mediaAsset": {
      "mediaId": "00001080-0000-0000-0000-000000000000",
      "fileName": "fileName0",
      "filePath": "filePath4",
      "fileUrl": "fileUrl0",
      "fileSize": 212,
      "fileFormat": "fileFormat2",
      "description": "description6"
    }
  }
}
```

