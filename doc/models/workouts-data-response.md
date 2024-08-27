
# Workouts Data Response

## Structure

`WorkoutsDataResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `string` | Required | - |
| `Message` | `string` | Required | - |
| `Data` | [`List<WorkoutData>`](../../doc/models/workout-data.md) | Optional | - |

## Example (as JSON)

```json
{
  "status": "OK",
  "message": "Workout data retrieved successfully",
  "data": [
    {
      "exerciseCode": "exerciseCode2",
      "exerciseNotes": "exerciseNotes8",
      "exerciseMetrics": [
        {
          "metricCode": "metricCode6",
          "metricUnit": "metricUnit0"
        }
      ],
      "exerciseData": [
        [
          98.87
        ]
      ],
      "exerciseOrder": 162
    },
    {
      "exerciseCode": "exerciseCode2",
      "exerciseNotes": "exerciseNotes8",
      "exerciseMetrics": [
        {
          "metricCode": "metricCode6",
          "metricUnit": "metricUnit0"
        }
      ],
      "exerciseData": [
        [
          98.87
        ]
      ],
      "exerciseOrder": 162
    }
  ]
}
```

