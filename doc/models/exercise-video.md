
# Exercise Video

## Structure

`ExerciseVideo`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ExerciseCode` | `string` | Optional | Unique identifier for the exercise. |
| `CreatorProfileId` | `Guid?` | Optional | Unique identifier for the creator profile. |
| `UserName` | `string` | Optional | Username of the user who created the video. |
| `MediaAsset` | [`MediaAsset`](../../doc/models/media-asset.md) | Optional | - |
| `SortOrder` | `int?` | Optional | The order in which the video should be displayed. |

## Example (as JSON)

```json
{
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
```

