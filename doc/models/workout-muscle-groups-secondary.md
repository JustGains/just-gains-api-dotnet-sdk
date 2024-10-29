
# Workout Muscle Groups Secondary

## Structure

`WorkoutMuscleGroupsSecondary`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `MuscleGroupCode` | `string` | Optional | Unique identifier for the muscle group. |
| `MuscleGroupName` | `string` | Optional | Name of the muscle group, localized. |
| `MuscleGroupThumbnail` | [`MediaAsset`](../../doc/models/media-asset.md) | Optional | - |

## Example (as JSON)

```json
{
  "muscleGroupCode": "CHEST",
  "muscleGroupName": "Chest",
  "muscleGroupThumbnail": {
    "mediaId": "000002a2-0000-0000-0000-000000000000",
    "fileName": "fileName0",
    "filePath": "filePath4",
    "fileUrl": "fileUrl0",
    "fileSize": 246,
    "fileFormat": "fileFormat2",
    "description": "description6"
  }
}
```

