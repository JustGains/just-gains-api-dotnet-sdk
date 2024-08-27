
# Workout Summary

Summary information about the workout.

## Structure

`WorkoutSummary`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `TotalReps` | `int?` | Optional | Total number of repetitions across all exercises in the workout. |
| `TotalSets` | `int?` | Optional | Total number of sets across all exercises in the workout. |
| `TotalVolume` | `double?` | Optional | Total volume (weight * reps) across all exercises in the workout. |
| `TotalDistance` | `double?` | Optional | Total distance covered in the workout, if applicable. |
| `EstimatedDuration` | `int?` | Optional | Estimated duration of the workout in minutes. |
| `ExerciseCount` | `int?` | Optional | Number of exercises in the workout. |

## Example (as JSON)

```json
{
  "totalReps": 100,
  "totalSets": 20,
  "totalVolume": 5000.5,
  "totalDistance": 5.5,
  "estimatedDuration": 60,
  "exerciseCount": 8
}
```

