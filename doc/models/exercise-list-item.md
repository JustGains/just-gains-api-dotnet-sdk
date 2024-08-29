
# Exercise List Item

## Structure

`ExerciseListItem`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ExerciseCode` | `string` | Optional | Unique identifier for the exercise. |
| `ExerciseName` | `string` | Optional | Translated Primary Exercise Name for the chosen Locale |
| `ExerciseMuscles` | [`List<ExerciseMuscle>`](../../doc/models/exercise-muscle.md) | Optional | - |
| `ExerciseThumbnail` | [`MediaAsset`](../../doc/models/media-asset.md) | Optional | - |
| `RecentOrder` | `int?` | Optional | Used for sorting by most recently used exercises. |
| `ExerciseTypeCode` | `string` | Optional | The exerciseTypeCode of the exercise |
| `ExerciseMetrics` | `List<string>` | Optional | Array of metric codes associated with this exercise |

## Example (as JSON)

```json
{
  "exerciseCode": "BENCH_PRESS",
  "exerciseName": "Bench Press",
  "exerciseMuscles": [
    {
      "muscleCode": "PECTORALIS_MAJOR",
      "targetPercentage": 50,
      "isPrimary": true
    },
    {
      "muscleCode": "ANTERIOR_DELTOID",
      "targetPercentage": 30,
      "isPrimary": false
    },
    {
      "muscleCode": "TRICEPS_BRACHII",
      "targetPercentage": 20,
      "isPrimary": false
    }
  ],
  "recentOrder": 1,
  "exerciseTypeCode": "STRENGTH",
  "exerciseMetrics": [
    "WEIGHT",
    "REPS",
    "DISTANCE"
  ],
  "exerciseThumbnail": {
    "mediaId": "000024ec-0000-0000-0000-000000000000",
    "fileName": "fileName8",
    "filePath": "filePath6",
    "fileUrl": "fileUrl8",
    "fileSize": 240,
    "fileFormat": "fileFormat0",
    "description": "description6"
  }
}
```

