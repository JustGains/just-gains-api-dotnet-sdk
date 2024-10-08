
# Workout Data List Response

## Structure

`WorkoutDataListResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `string` | Required | The status of the response, corresponding to standard HTTP status codes. |
| `Message` | `string` | Required | A human-readable message describing the result of the operation. |
| `Data` | [`List<WorkoutData>`](../../doc/models/workout-data.md) | Required | - |

## Example (as JSON)

```json
{
  "status": "OK",
  "message": "Operation completed successfully.",
  "data": [
    {
      "exerciseCode": "BARBELL_SQUAT",
      "exerciseNotes": "Keep your core tight throughout the movement",
      "exerciseMetrics": [
        {
          "metricCode": "WEIGHT",
          "metricUnit": "KG"
        },
        {
          "metricCode": "REPS",
          "metricUnit": "COUNT"
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
  ]
}
```

