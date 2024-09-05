
# Workout Response

## Structure

`WorkoutResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `string` | Required | The status of the response, corresponding to standard HTTP status codes. |
| `Message` | `string` | Required | A human-readable message describing the result of the operation. |
| `Data` | [`Workout`](../../doc/models/workout.md) | Required | Represents a workout in the system. |

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

