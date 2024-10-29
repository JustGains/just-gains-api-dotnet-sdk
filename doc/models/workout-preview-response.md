
# Workout Preview Response

## Structure

`WorkoutPreviewResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `string` | Required | The status of the response, corresponding to standard HTTP status codes. |
| `Message` | `string` | Required | A human-readable message describing the result of the operation. |
| `Data` | [`WorkoutPreview`](../../doc/models/workout-preview.md) | Required | Represents a workout in the system. |

## Example (as JSON)

```json
{
  "status": "OK",
  "message": "Operation completed successfully.",
  "data": {
    "workoutId": "9f897bfa-716d-4caa-b8fb-20bf3f2f3416",
    "workoutTitle": "Full Body Strength Training",
    "updatedAt": "07/08/2023 14:30:00",
    "lastViewedAt": "07/07/2023 09:15:00",
    "workoutBackgroundImage": {
      "mediaId": "00001014-0000-0000-0000-000000000000",
      "fileName": "fileName2",
      "filePath": "filePath2",
      "fileUrl": "fileUrl2",
      "fileSize": 88,
      "fileFormat": "fileFormat4",
      "description": "description8"
    },
    "workoutMuscleGroupsPrimary": [
      {
        "muscleGroupCode": "muscleGroupCode8",
        "muscleGroupName": "muscleGroupName8",
        "muscleGroupThumbnail": {
          "mediaId": "000002a2-0000-0000-0000-000000000000",
          "fileName": "fileName0",
          "filePath": "filePath4",
          "fileUrl": "fileUrl0",
          "fileSize": 246,
          "fileFormat": "fileFormat2",
          "description": "description6"
        }
      },
      {
        "muscleGroupCode": "muscleGroupCode8",
        "muscleGroupName": "muscleGroupName8",
        "muscleGroupThumbnail": {
          "mediaId": "000002a2-0000-0000-0000-000000000000",
          "fileName": "fileName0",
          "filePath": "filePath4",
          "fileUrl": "fileUrl0",
          "fileSize": 246,
          "fileFormat": "fileFormat2",
          "description": "description6"
        }
      },
      {
        "muscleGroupCode": "muscleGroupCode8",
        "muscleGroupName": "muscleGroupName8",
        "muscleGroupThumbnail": {
          "mediaId": "000002a2-0000-0000-0000-000000000000",
          "fileName": "fileName0",
          "filePath": "filePath4",
          "fileUrl": "fileUrl0",
          "fileSize": 246,
          "fileFormat": "fileFormat2",
          "description": "description6"
        }
      }
    ],
    "workoutMuscleGroupsSecondary": [
      {
        "muscleGroupCode": "muscleGroupCode0",
        "muscleGroupName": "muscleGroupName6",
        "muscleGroupThumbnail": {
          "mediaId": "000002a2-0000-0000-0000-000000000000",
          "fileName": "fileName0",
          "filePath": "filePath4",
          "fileUrl": "fileUrl0",
          "fileSize": 246,
          "fileFormat": "fileFormat2",
          "description": "description6"
        }
      },
      {
        "muscleGroupCode": "muscleGroupCode0",
        "muscleGroupName": "muscleGroupName6",
        "muscleGroupThumbnail": {
          "mediaId": "000002a2-0000-0000-0000-000000000000",
          "fileName": "fileName0",
          "filePath": "filePath4",
          "fileUrl": "fileUrl0",
          "fileSize": 246,
          "fileFormat": "fileFormat2",
          "description": "description6"
        }
      }
    ]
  }
}
```

