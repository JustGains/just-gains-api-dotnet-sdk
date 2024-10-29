
# Workout Content Response

## Structure

`WorkoutContentResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `string` | Required | The status of the response, corresponding to standard HTTP status codes. |
| `Message` | `string` | Required | A human-readable message describing the result of the operation. |
| `Data` | [`WorkoutContent`](../../doc/models/workout-content.md) | Required | - |

## Example (as JSON)

```json
{
  "status": "OK",
  "message": "Operation completed successfully.",
  "data": {
    "workoutID": "9f897bfa-716d-4caa-b8fb-20bf3f2f3416",
    "updatedAt": "07/08/2023 14:30:00",
    "workoutContent": {
      "key1": "val1",
      "key2": "val2"
    }
  }
}
```

