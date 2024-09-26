
# Exercise List Item

## Structure

`ExerciseListItem`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ExerciseCode` | `string` | Optional | Unique identifier for the exercise. |
| `ExerciseName` | `string` | Optional | Translated Primary Exercise Name for the chosen Locale |
| `ExerciseTypeCode` | `string` | Optional | The exerciseTypeCode of the exercise |
| `ExerciseCategories` | `List<string>` | Optional | Array of category codes associated with this exercise |
| `PublishedStatus` | `string` | Optional | The publish status of the exercise |
| `ExerciseMuscles` | [`List<ExerciseMuscle>`](../../doc/models/exercise-muscle.md) | Optional | - |
| `ExerciseThumbnail` | [`MediaAsset`](../../doc/models/media-asset.md) | Optional | - |
| `ExerciseMetrics` | `List<string>` | Optional | Array of metric codes associated with this exercise |
| `RecentOrder` | `int?` | Optional | Used for sorting by most recently used exercises. |

## Example (as JSON)

```json
{
  "exerciseCode": "BENCH_PRESS",
  "exerciseName": "Bench Press",
  "exerciseTypeCode": "STRENGTH",
  "exerciseCategories": [
    "STRENGTH",
    "CARDIO"
  ],
  "publishedStatus": "PUBLISHED",
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
  "exerciseMetrics": [
    "WEIGHT",
    "REPS",
    "DISTANCE"
  ],
  "recentOrder": 1
}
```

