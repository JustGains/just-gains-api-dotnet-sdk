
# Workout Table Item

Represents a workout in the system from the My Workouts Page.

## Structure

`WorkoutTableItem`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `WorkoutId` | `int?` | Optional | Unique identifier for the workout. |
| `WorkoutTitle` | `string` | Optional | The title of the workout. |
| `WorkoutImage` | [`MediaAsset`](../../doc/models/media-asset.md) | Optional | - |
| `IsMyWorkout` | `bool?` | Optional | Indicates if the workout is a user's own workout. |
| `CreatorCredits` | [`List<CreatorCredit>`](../../doc/models/creator-credit.md) | Optional | List of creator credits associated with this workout. |
| `PrimaryMuscleGroups` | `List<string>` | Optional | List of primary muscle group codes targeted in the workout.<br>**Constraints**: *Pattern*: `^[A-Z_]+$` |
| `EquipmentList` | `List<string>` | Optional | List of equipment codes used in the workout.<br>**Constraints**: *Pattern*: `^[A-Z_]+$` |
| `SecondaryMuscleGroups` | `List<string>` | Optional | List of secondary muscles targeted in the workout.<br>**Constraints**: *Pattern*: `^[A-Z_]+$` |
| `CreatedAt` | `DateTime?` | Optional | The date and time when the workout was created. |
| `UpdatedAt` | `DateTime?` | Optional | The date and time when the workout was last updated. |
| `LastUsedAt` | `DateTime?` | Optional | The date and time when the workout was last used. |
| `Tags` | `List<string>` | Optional | NOT IMPLEMENTED:- TODO- List of tags associated with the workout. |
| `WorkoutSummary` | [`WorkoutSummary`](../../doc/models/workout-summary.md) | Optional | Summary information about the workout. |
| `Analytics` | [`WorkoutAnalytics`](../../doc/models/workout-analytics.md) | Optional | Analytics data for the workout. |
| `OriginalWorkoutId` | `int?` | Optional | ID of the original workout if this is a duplicate. |

## Example (as JSON)

```json
{
  "workoutId": 1234,
  "workoutTitle": "Full Body Strength Training",
  "isMyWorkout": true,
  "primaryMuscleGroups": [
    "CHEST",
    "QUADRICEPS",
    "BACK"
  ],
  "equipmentList": [
    "BARBELL",
    "BENCH",
    "DUMBBELL"
  ],
  "secondaryMuscleGroups": [
    "CHEST",
    "QUADRICEPS",
    "BACK"
  ],
  "createdAt": "07/01/2023 10:00:00",
  "updatedAt": "07/08/2023 14:30:00",
  "lastUsedAt": "07/07/2023 09:15:00",
  "tags": [
    "strength",
    "fullbody",
    "beginner"
  ],
  "originalWorkoutId": 1000,
  "workoutImage": {
    "mediaId": "00000cf4-0000-0000-0000-000000000000",
    "fileName": "fileName2",
    "filePath": "filePath2",
    "fileUrl": "fileUrl2",
    "fileSize": 40,
    "fileFormat": "fileFormat4",
    "description": "description8"
  },
  "creatorCredits": [
    {
      "creatorProfileId": "00002506-0000-0000-0000-000000000000",
      "workoutSourceURL": "workoutSourceURL2",
      "contributionType": "ORIGINAL_AUTHOR",
      "creatorProfile": {
        "creatorProfileId": "00001068-0000-0000-0000-000000000000",
        "userId": "00001b82-0000-0000-0000-000000000000",
        "userName": "userName4",
        "creatorEmail": "creatorEmail0",
        "profilePhoto": {
          "mediaId": "000006b6-0000-0000-0000-000000000000",
          "fileName": "fileName4",
          "filePath": "filePath0",
          "fileUrl": "fileUrl4",
          "fileSize": 10,
          "fileFormat": "fileFormat6",
          "description": "description0"
        }
      }
    }
  ]
}
```

