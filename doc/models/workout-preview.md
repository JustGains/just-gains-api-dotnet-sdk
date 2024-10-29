
# Workout Preview

Represents a workout in the system.

## Structure

`WorkoutPreview`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `WorkoutId` | `Guid?` | Optional | Unique identifier for the workout. |
| `WorkoutTitle` | `string` | Optional | The title of the workout. |
| `WorkoutBackgroundImage` | [`MediaAsset`](../../doc/models/media-asset.md) | Optional | - |
| `WorkoutMuscleGroupsPrimary` | [`List<WorkoutMuscleGroupsPrimary>`](../../doc/models/workout-muscle-groups-primary.md) | Optional | - |
| `WorkoutMuscleGroupsSecondary` | [`List<WorkoutMuscleGroupsSecondary>`](../../doc/models/workout-muscle-groups-secondary.md) | Optional | - |
| `WorkoutEquipmentGroups` | [`List<WorkoutEquipmentGroup>`](../../doc/models/workout-equipment-group.md) | Optional | - |
| `UpdatedAt` | `DateTime?` | Optional | The date and time when the workout was last updated. |
| `LastViewedAt` | `DateTime?` | Optional | The date and time when the workout was last used. |
| `WorkoutData` | [`List<WorkoutData>`](../../doc/models/workout-data.md) | Optional | - |
| `WorkoutContent` | [`WorkoutContent`](../../doc/models/workout-content.md) | Optional | - |
| `WorkoutSummary` | [`WorkoutSummary`](../../doc/models/workout-summary.md) | Optional | Summary information about the workout. |
| `WorkoutAnalytics` | [`WorkoutAnalytics`](../../doc/models/workout-analytics.md) | Optional | Analytics data for the workout. |
| `CreatorCredits` | [`List<CreatorCredit>`](../../doc/models/creator-credit.md) | Optional | List of creator credits associated with this workout. |

## Example (as JSON)

```json
{
  "workoutId": "9f897bfa-716d-4caa-b8fb-20bf3f2f3416",
  "workoutTitle": "Full Body Strength Training",
  "updatedAt": "07/08/2023 14:30:00",
  "lastViewedAt": "07/07/2023 09:15:00",
  "workoutBackgroundImage": {
    "mediaId": "00001014-0000-0000-0000-000000000000",
    "fileName": "fileName2",
    "filePath": "filePath2",
    "fileUrl": "fileUrl2",
    "fileSize": 88,
    "fileFormat": "fileFormat4",
    "description": "description8"
  },
  "workoutMuscleGroupsPrimary": [
    {
      "muscleGroupCode": "muscleGroupCode8",
      "muscleGroupName": "muscleGroupName8",
      "muscleGroupThumbnail": {
        "mediaId": "000002a2-0000-0000-0000-000000000000",
        "fileName": "fileName0",
        "filePath": "filePath4",
        "fileUrl": "fileUrl0",
        "fileSize": 246,
        "fileFormat": "fileFormat2",
        "description": "description6"
      }
    },
    {
      "muscleGroupCode": "muscleGroupCode8",
      "muscleGroupName": "muscleGroupName8",
      "muscleGroupThumbnail": {
        "mediaId": "000002a2-0000-0000-0000-000000000000",
        "fileName": "fileName0",
        "filePath": "filePath4",
        "fileUrl": "fileUrl0",
        "fileSize": 246,
        "fileFormat": "fileFormat2",
        "description": "description6"
      }
    },
    {
      "muscleGroupCode": "muscleGroupCode8",
      "muscleGroupName": "muscleGroupName8",
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
  ],
  "workoutMuscleGroupsSecondary": [
    {
      "muscleGroupCode": "muscleGroupCode0",
      "muscleGroupName": "muscleGroupName6",
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
  ]
}
```

