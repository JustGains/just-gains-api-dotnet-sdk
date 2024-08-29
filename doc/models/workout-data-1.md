
# Workout Data 1

The data returned by the operation.

## Structure

`WorkoutData1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ExerciseCode` | `string` | Optional | Unique identifier for the exercise. |
| `ExerciseNotes` | `string` | Optional | Additional notes or instructions for this specific instance of the exercise. |
| `ExerciseMetrics` | [`List<ExerciseMetric1>`](../../doc/models/exercise-metric-1.md) | Optional | List of metric codes and their units used for this exercise, in order |
| `ExerciseData` | `List<List<double>>` | Optional | Array of sets, each containing the set number and metric values in order. |
| `ExerciseOrder` | `int?` | Optional | The order of this exercise within the workout or its group. |
| `ExerciseGroupID` | `int?` | Optional | Identifier for the group this exercise belongs to, if any. Null if not part of a group. |
| `ExerciseGroupType` | [`ExerciseGroupTypeEnum?`](../../doc/models/exercise-group-type-enum.md) | Optional | The type of group this exercise belongs to, if any. Null if not part of a group. |

## Example (as JSON)

```json
{
  "exerciseCode": "BARBELL_SQUAT",
  "exerciseNotes": "Keep your core tight throughout the movement",
  "exerciseMetrics": [
    {
      "code": "WEIGHT",
      "unit": "KG",
      "metricCode": "metricCode6",
      "metricUnit": "metricUnit0"
    },
    {
      "code": "REPS",
      "unit": "COUNT",
      "metricCode": "metricCode6",
      "metricUnit": "metricUnit0"
    }
  ],
  "exerciseData": [
    [
      1.0,
      100.0,
      10.0
    ],
    [
      2.0,
      110.0,
      8.0
    ],
    [
      3.0,
      120.0,
      6.0
    ],
    [
      4.0,
      120.0,
      6.0
    ]
  ],
  "exerciseOrder": 2,
  "exerciseGroupID": 1,
  "exerciseGroupType": "SUPERSET"
}
```

