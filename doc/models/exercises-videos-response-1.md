
# Exercises Videos Response 1

## Structure

`ExercisesVideosResponse1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `string` | Required | - |
| `Message` | `string` | Required | - |
| `Data` | [`ExerciseVideo`](../../doc/models/exercise-video.md) | Optional | - |

## Example (as JSON)

```json
{
  "status": "Created",
  "message": "Exercise videos created successfully",
  "data": {
    "exerciseCode": "exerciseCode2",
    "userId": "000018a6-0000-0000-0000-000000000000",
    "mediaElement": {
      "mediaId": "00001ea4-0000-0000-0000-000000000000",
      "fileName": "fileName0",
      "filePath": "filePath4",
      "fileUrl": "fileUrl0",
      "fileSize": 200,
      "fileFormat": "fileFormat2",
      "description": "description6"
    },
    "sortOrder": 70
  }
}
```

