
# Exercise Video List Response

## Structure

`ExerciseVideoListResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `string` | Required | The status of the response, corresponding to standard HTTP status codes. |
| `Message` | `string` | Required | A human-readable message describing the result of the operation. |
| `Data` | [`List<ExerciseVideoListItem>`](../../doc/models/exercise-video-list-item.md) | Required | The data returned by the operation. |

## Example (as JSON)

```json
{
  "status": "OK",
  "message": "Operation completed successfully.",
  "data": [
    {
      "userId": "9fdd12f5-c7b9-82a8-f6cc-cceac14c13c1",
      "dateUpdated": "2023-07-10T11:45:00Z",
      "dateCreated": "2023-06-15T08:30:00Z"
    }
  ]
}
```

