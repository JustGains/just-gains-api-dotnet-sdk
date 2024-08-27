
# Exercises Response 1

## Structure

`ExercisesResponse1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `string` | Required | - |
| `Message` | `string` | Required | - |
| `Data` | [`ExerciseList`](../../doc/models/exercise-list.md) | Optional | - |

## Example (as JSON)

```json
{
  "status": "Created",
  "message": "Exercise created successfully",
  "data": {
    "exerciseCode": "exerciseCode2",
    "exerciseName": "exerciseName2",
    "exerciseMuscles": [
      {
        "muscleCode": "muscleCode6",
        "targetPercentage": 202,
        "isPrimary": false
      }
    ],
    "exerciseThumbnail": {
      "mediaId": "000024ec-0000-0000-0000-000000000000",
      "fileName": "fileName8",
      "filePath": "filePath6",
      "fileUrl": "fileUrl8",
      "fileSize": 240,
      "fileFormat": "fileFormat0",
      "description": "description6"
    },
    "recentOrder": 6
  }
}
```

