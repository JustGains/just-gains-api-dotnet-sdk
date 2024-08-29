
# Workout Response

## Structure

`WorkoutResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `string` | Required | The status of the response, corresponding to standard HTTP status codes. |
| `Message` | `string` | Required | A human-readable message describing the result of the operation. |
| `Data` | [`Workout1`](../../doc/models/workout-1.md) | Required | The data returned by the operation. |

## Example (as JSON)

```json
{
  "status": "OK",
  "message": "Operation completed successfully.",
  "data": {
    "workoutId": 1234,
    "workoutTitle": "Full Body Strength Training",
    "updatedAt": "07/08/2023 14:30:00",
    "lastUsedAt": "07/07/2023 09:15:00",
    "totalUses": 15,
    "averageRating": 4.7
  }
}
```

