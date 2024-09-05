
# Exercise Video 1

The data returned by the operation.

## Structure

`ExerciseVideo1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ExerciseCode` | `string` | Optional | Unique identifier for the exercise. |
| `UserId` | `Guid?` | Optional | The user ID of the user who created the exercise. |
| `MediaAsset` | [`MediaAsset`](../../doc/models/media-asset.md) | Optional | - |
| `SortOrder` | `int?` | Optional | The order in which the video should be displayed. |

## Example (as JSON)

```json
{
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
```

