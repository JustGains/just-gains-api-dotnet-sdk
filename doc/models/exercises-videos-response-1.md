
# Exercises Videos Response 1

## Structure

`ExercisesVideosResponse1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`List<ExerciseVideoResponse>`](../../doc/models/exercise-video-response.md) | Optional | - |
| `Message` | `object` | Optional | - |

## Example (as JSON)

```json
{
  "message": {
    "key1": "val1",
    "key2": "val2"
  },
  "data": [
    {
      "status": "status2",
      "message": "message0",
      "data": {
        "exerciseCode": "exerciseCode2",
        "creatorProfileId": "00000d8c-0000-0000-0000-000000000000",
        "userName": "userName2",
        "mediaAsset": {
          "mediaId": "00001080-0000-0000-0000-000000000000",
          "fileName": "fileName0",
          "filePath": "filePath4",
          "fileUrl": "fileUrl0",
          "fileSize": 212,
          "fileFormat": "fileFormat2",
          "description": "description6"
        },
        "sortOrder": 70
      }
    }
  ]
}
```

