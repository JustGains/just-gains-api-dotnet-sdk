
# Exercise List Response

## Structure

`ExerciseListResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `string` | Required | The status of the response, corresponding to standard HTTP status codes. |
| `Message` | `string` | Required | A human-readable message describing the result of the operation. |
| `Data` | [`List<ExerciseListItem>`](../../doc/models/exercise-list-item.md) | Required | - |
| `Pagination` | [`Pagination`](../../doc/models/pagination.md) | Optional | - |

## Example (as JSON)

```json
{
  "status": "OK",
  "message": "Operation completed successfully.",
  "data": [
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
  ],
  "pagination": {
    "currentPage": 166,
    "totalPages": 154,
    "pageSize": 134,
    "totalCount": 250,
    "hasPrevious": false
  }
}
```

