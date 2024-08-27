
# Exercises Videos Response

## Structure

`ExercisesVideosResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `string` | Required | - |
| `Message` | `string` | Required | - |
| `Data` | [`ExerciseVideoList`](../../doc/models/exercise-video-list.md) | Optional | - |

## Example (as JSON)

```json
{
  "status": "OK",
  "message": "Exercise videos retrieved successfully",
  "data": {
    "userId": "userId0",
    "dateUpdated": "2016-03-13T12:52:32.123Z",
    "dateCreated": "2016-03-13T12:52:32.123Z"
  }
}
```

