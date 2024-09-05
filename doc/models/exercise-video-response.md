
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
    "userId": "123e4567-e89b-12d3-a456-426614174000",
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

