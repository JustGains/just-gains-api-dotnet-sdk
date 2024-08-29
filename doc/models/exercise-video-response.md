
# Exercise Video Response

## Structure

`ExerciseVideoResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `string` | Required | The status of the response, corresponding to standard HTTP status codes. |
| `Message` | `string` | Required | A human-readable message describing the result of the operation. |
| `Data` | [`ExerciseVideo1`](../../doc/models/exercise-video-1.md) | Required | The data returned by the operation. |

## Example (as JSON)

```json
{
  "status": "OK",
  "message": "Operation completed successfully.",
  "data": {
    "exerciseCode": "BARBELL_SQUAT",
    "userId": "123e4567-e89b-12d3-a456-426614174000",
    "sortOrder": 1,
    "mediaElement": {
      "mediaId": "00001ea4-0000-0000-0000-000000000000",
      "fileName": "fileName0",
      "filePath": "filePath4",
      "fileUrl": "fileUrl0",
      "fileSize": 200,
      "fileFormat": "fileFormat2",
      "description": "description6"
    }
  }
}
```

