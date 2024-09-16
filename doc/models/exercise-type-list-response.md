
# Exercise Type List Response

## Structure

`ExerciseTypeListResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `string` | Required | The status of the response, corresponding to standard HTTP status codes. |
| `Message` | `string` | Required | A human-readable message describing the result of the operation. |
| `Data` | [`List<ExerciseType>`](../../doc/models/exercise-type.md) | Required | - |

## Example (as JSON)

```json
{
  "status": "OK",
  "message": "Operation completed successfully.",
  "data": [
    {
      "exerciseTypeCode": "WEIGHT_REPS",
      "exerciseTypeName": "Weight and Repetitions",
      "exerciseTypeExerciseMetrics": [
        "WEIGHT",
        "REPS"
      ]
    }
  ]
}
```

