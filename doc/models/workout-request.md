
# Workout Request

A new workout being created by POST - All fields optional

## Structure

`WorkoutRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `WorkoutTitle` | `string` | Optional | The title of the workout. |
| `WorkoutBackgroundImage` | [`MediaAsset`](../../doc/models/media-asset.md) | Optional | - |
| `WorkoutContent` | `object` | Optional | The content of the workout (JSON formatted output from the JS Editor) |
| `WorkoutData` | [`List<WorkoutData>`](../../doc/models/workout-data.md) | Optional | - |
| `CreatorCredits` | [`List<CreatorCredit>`](../../doc/models/creator-credit.md) | Optional | List of creator credits associated with this workout. |

## Example (as JSON)

```json
{
  "workoutTitle": "Full Body Strength Training",
  "workoutContent": {},
  "workoutBackgroundImage": {
    "mediaId": "00001014-0000-0000-0000-000000000000",
    "fileName": "fileName2",
    "filePath": "filePath2",
    "fileUrl": "fileUrl2",
    "fileSize": 88,
    "fileFormat": "fileFormat4",
    "description": "description8"
  },
  "workoutData": [
    {
      "exerciseCode": "exerciseCode2",
      "exerciseNotes": "exerciseNotes8",
      "exerciseThumbnail": {
        "mediaId": "000024ec-0000-0000-0000-000000000000",
        "fileName": "fileName8",
        "filePath": "filePath6",
        "fileUrl": "fileUrl8",
        "fileSize": 240,
        "fileFormat": "fileFormat0",
        "description": "description6"
      },
      "exerciseMetrics": [
        {
          "metricCode": "metricCode6",
          "metricUnit": "metricUnit0"
        },
        {
          "metricCode": "metricCode6",
          "metricUnit": "metricUnit0"
        }
      ],
      "exerciseOrder": 132
    },
    {
      "exerciseCode": "exerciseCode2",
      "exerciseNotes": "exerciseNotes8",
      "exerciseThumbnail": {
        "mediaId": "000024ec-0000-0000-0000-000000000000",
        "fileName": "fileName8",
        "filePath": "filePath6",
        "fileUrl": "fileUrl8",
        "fileSize": 240,
        "fileFormat": "fileFormat0",
        "description": "description6"
      },
      "exerciseMetrics": [
        {
          "metricCode": "metricCode6",
          "metricUnit": "metricUnit0"
        },
        {
          "metricCode": "metricCode6",
          "metricUnit": "metricUnit0"
        }
      ],
      "exerciseOrder": 132
    }
  ],
  "creatorCredits": [
    {
      "creatorProfileId": "00002506-0000-0000-0000-000000000000",
      "workoutSourceURL": "workoutSourceURL2",
      "contributionType": "ORIGINAL_AUTHOR",
      "creatorProfile": {
        "creatorProfileId": "00001068-0000-0000-0000-000000000000",
        "userId": "00001b82-0000-0000-0000-000000000000",
        "userName": "userName4",
        "firstName": "firstName8",
        "lastName": "lastName6"
      }
    },
    {
      "creatorProfileId": "00002506-0000-0000-0000-000000000000",
      "workoutSourceURL": "workoutSourceURL2",
      "contributionType": "ORIGINAL_AUTHOR",
      "creatorProfile": {
        "creatorProfileId": "00001068-0000-0000-0000-000000000000",
        "userId": "00001b82-0000-0000-0000-000000000000",
        "userName": "userName4",
        "firstName": "firstName8",
        "lastName": "lastName6"
      }
    },
    {
      "creatorProfileId": "00002506-0000-0000-0000-000000000000",
      "workoutSourceURL": "workoutSourceURL2",
      "contributionType": "ORIGINAL_AUTHOR",
      "creatorProfile": {
        "creatorProfileId": "00001068-0000-0000-0000-000000000000",
        "userId": "00001b82-0000-0000-0000-000000000000",
        "userName": "userName4",
        "firstName": "firstName8",
        "lastName": "lastName6"
      }
    }
  ]
}
```

