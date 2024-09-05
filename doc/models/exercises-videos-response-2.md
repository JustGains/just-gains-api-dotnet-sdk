
# Exercises Videos Response 2

## Structure

`ExercisesVideosResponse2`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`List<ExerciseVideoResponse>`](../../doc/models/exercise-video-response.md) | Optional | - |
| `Message` | `object` | Optional | - |

## Example (as JSON)

```json
{
  "data": [
    {
      "status": "status2",
      "message": "message0",
      "data": {
        "exerciseCode": "exerciseCode2",
        "userId": "000018a6-0000-0000-0000-000000000000",
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
    },
    {
      "status": "status2",
      "message": "message0",
      "data": {
        "exerciseCode": "exerciseCode2",
        "userId": "000018a6-0000-0000-0000-000000000000",
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
  ],
  "message": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

