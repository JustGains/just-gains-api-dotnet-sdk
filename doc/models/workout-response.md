
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
    "workoutId": "9f897bfa-716d-4caa-b8fb-20bf3f2f3416",
    "originalWorkoutId": "9f897bfa-716d-4caa-b8fb-20bf3f2f3416",
    "workoutTitle": "Full Body Strength Training",
    "workoutSlug": "full-body-strength-training",
    "createdAt": "07/01/2023 10:00:00",
    "updatedAt": "07/08/2023 14:30:00",
    "lastViewedAt": "07/07/2023 09:15:00",
    "workoutContent": {},
    "workoutBackgroundImage": {
      "mediaId": "00001014-0000-0000-0000-000000000000",
      "fileName": "fileName2",
      "filePath": "filePath2",
      "fileUrl": "fileUrl2",
      "fileSize": 88,
      "fileFormat": "fileFormat4",
      "description": "description8"
    }
  }
}
```

