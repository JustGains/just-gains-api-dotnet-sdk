
# Workout Table List Response

## Structure

`WorkoutTableListResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `string` | Required | The status of the response, corresponding to standard HTTP status codes. |
| `Message` | `string` | Required | A human-readable message describing the result of the operation. |
| `Data` | [`List<WorkoutTableItem>`](../../doc/models/workout-table-item.md) | Required | The data returned by the operation. |
| `Pagination` | [`Pagination`](../../doc/models/pagination.md) | Optional | - |

## Example (as JSON)

```json
{
  "status": "OK",
  "message": "Operation completed successfully.",
  "data": [
    {
      "workoutId": 1234,
      "workoutTitle": "Full Body Strength Training",
      "isMyWorkout": true,
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
      "lastUsedAt": "07/07/2023 09:15:00",
      "tags": [
        "strength",
        "fullbody",
        "beginner"
      ],
      "originalWorkoutId": 1000,
      "workoutImage": {
        "mediaId": "00000cf4-0000-0000-0000-000000000000",
        "fileName": "fileName2",
        "filePath": "filePath2",
        "fileUrl": "fileUrl2",
        "fileSize": 40,
        "fileFormat": "fileFormat4",
        "description": "description8"
      },
      "creatorCredits": [
        {
          "creatorProfileId": "00002506-0000-0000-0000-000000000000",
          "workoutSourceURL": "workoutSourceURL2",
          "contributionType": "ORIGINAL_AUTHOR",
          "creatorProfile": {
            "creatorProfileId": "00001068-0000-0000-0000-000000000000",
            "userId": "00001b82-0000-0000-0000-000000000000",
            "creatorEmail": "creatorEmail0",
            "profilePhoto": {
              "mediaId": "000006b6-0000-0000-0000-000000000000",
              "fileName": "fileName4",
              "filePath": "filePath0",
              "fileUrl": "fileUrl4",
              "fileSize": 10,
              "fileFormat": "fileFormat6",
              "description": "description0"
            },
            "socialMediaAccounts": [
              {
                "socialMediaPlatformCode": "socialMediaPlatformCode8",
                "socialMediaAccountUsername": "socialMediaAccountUsername8"
              },
              {
                "socialMediaPlatformCode": "socialMediaPlatformCode8",
                "socialMediaAccountUsername": "socialMediaAccountUsername8"
              }
            ]
          }
        }
      ]
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

