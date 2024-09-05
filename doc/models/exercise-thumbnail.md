
# Exercise Thumbnail

## Structure

`ExerciseThumbnail`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ExerciseCode` | `string` | Required | Unique identifier for the exercise. |
| `UserId` | `Guid` | Required | The user ID of the user who created the thumbnail. |
| `MediaAsset` | [`MediaAsset`](../../doc/models/media-asset.md) | Required | - |

## Example (as JSON)

```json
{
  "exerciseCode": "exerciseCode4",
  "userId": "000020e6-0000-0000-0000-000000000000",
  "mediaAsset": {
    "mediaId": "7b8e9f2a-c1d3-45e6-a7b8-9c0d1e2f3a4b",
    "fileName": "workout_routine.mp4",
    "filePath": "media/videos/routines/workout_routine.mp4",
    "fileUrl": "https://api.justsuperhuman.com/media/videos/routines/workout_routine.mp4",
    "fileSize": 15728640,
    "fileFormat": "video/mp4",
    "description": "High-intensity interval training (HIIT) workout routine for beginners"
  }
}
```

