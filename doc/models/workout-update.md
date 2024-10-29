
# Workout Update

## Structure

`WorkoutUpdate`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `WorkoutTitle` | `string` | Optional | The title of the workout. |
| `WorkoutBackgroundImage` | [`MediaAsset`](../../doc/models/media-asset.md) | Optional | - |
| `WorkoutSlug` | `string` | Optional | The URL slug of the workout. |
| `Tags` | `List<string>` | Optional | (NOT IMPLEMENTED) List of tags associated with the workout. |

## Example (as JSON)

```json
{
  "workoutTitle": "Full Body Strength Training",
  "workoutSlug": "full-body-strength-training",
  "tags": [
    "strength",
    "fullbody",
    "beginner"
  ],
  "workoutBackgroundImage": {
    "mediaId": "00001014-0000-0000-0000-000000000000",
    "fileName": "fileName2",
    "filePath": "filePath2",
    "fileUrl": "fileUrl2",
    "fileSize": 88,
    "fileFormat": "fileFormat4",
    "description": "description8"
  }
}
```

