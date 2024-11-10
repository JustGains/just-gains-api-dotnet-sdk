
# Workout Table List Response

## Structure

`WorkoutTableListResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `string` | Required | The status of the response, corresponding to standard HTTP status codes. |
| `Message` | `string` | Required | A human-readable message describing the result of the operation. |
| `Data` | [`List<WorkoutTableItem>`](../../doc/models/workout-table-item.md) | Required | - |
| `Pagination` | [`Pagination`](../../doc/models/pagination.md) | Optional | - |

## Example (as JSON)

```json
{
  "status": "OK",
  "message": "Operation completed successfully.",
  "data": [
    {
      "workoutId": "9f897bfa-716d-4caa-b8fb-20bf3f2f3416",
      "originalWorkoutId": "9f897bfa-716d-4caa-b8fb-20bf3f2f3416",
      "workoutTitle": "Full Body Strength Training",
      "workoutSlug": "full-body-strength-training",
      "isBookmark": true,
      "primaryMuscleGroups": [
        "CHEST",
        "QUADRICEPS",
        "BACK"
      ],
      "equipmentList": [
        "BARBELL",
        "BENCH",
        "DUMBBELL"
      ],
      "secondaryMuscleGroups": [
        "CHEST",
        "QUADRICEPS",
        "BACK"
      ],
      "createdAt": "07/01/2023 10:00:00",
      "updatedAt": "07/08/2023 14:30:00",
      "lastViewedAt": "07/07/2023 09:15:00",
      "tags": [
        "strength",
        "fullbody",
        "beginner"
      ],
      "WorkoutBackgroundImage": {
        "mediaId": "00000cba-0000-0000-0000-000000000000",
        "fileName": "fileName4",
        "filePath": "filePath0",
        "fileUrl": "fileUrl4",
        "fileSize": 14,
        "fileFormat": "fileFormat6",
        "description": "description0"
      }
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

