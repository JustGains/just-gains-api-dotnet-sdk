
# Workouts Response

## Structure

`WorkoutsResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `string` | Required | - |
| `Message` | `string` | Required | - |
| `Data` | [`List<WorkoutTableData>`](../../doc/models/workout-table-data.md) | Optional | - |
| `Pagination` | [`Pagination`](../../doc/models/pagination.md) | Optional | - |

## Example (as JSON)

```json
{
  "status": "OK",
  "message": "Workouts retrieved successfully",
  "data": [
    {
      "workoutId": 20,
      "workoutTitle": "workoutTitle8",
      "workoutImage": {
        "mediaId": "00000cf4-0000-0000-0000-000000000000",
        "fileName": "fileName2",
        "filePath": "filePath2",
        "fileUrl": "fileUrl2",
        "fileSize": 40,
        "fileFormat": "fileFormat4",
        "description": "description8"
      },
      "isMyWorkout": false,
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
    },
    {
      "workoutId": 20,
      "workoutTitle": "workoutTitle8",
      "workoutImage": {
        "mediaId": "00000cf4-0000-0000-0000-000000000000",
        "fileName": "fileName2",
        "filePath": "filePath2",
        "fileUrl": "fileUrl2",
        "fileSize": 40,
        "fileFormat": "fileFormat4",
        "description": "description8"
      },
      "isMyWorkout": false,
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

