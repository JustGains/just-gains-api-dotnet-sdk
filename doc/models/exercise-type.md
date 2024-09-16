
# Exercise Type

Represents a type of exercise and its associated metrics.

## Structure

`ExerciseType`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ExerciseTypeCode` | `string` | Optional | A unique identifier for the exercise type. |
| `ExerciseTypeName` | `string` | Optional | The name of the exercise type. |
| `ExerciseTypeExerciseMetrics` | `List<string>` | Optional | An array of metric codes associated with this exercise type. These metrics are used to measure and track performance for exercises of this type. |

## Example (as JSON)

```json
{
  "exerciseTypeCode": "WEIGHT_REPS",
  "exerciseTypeName": "Weight and Repetitions",
  "exerciseTypeExerciseMetrics": [
    "WEIGHT",
    "REPS"
  ]
}
```

