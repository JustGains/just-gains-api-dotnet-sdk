
# Week Response

## Structure

`WeekResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `string` | Required | The status of the response, corresponding to standard HTTP status codes. |
| `Message` | `string` | Required | A human-readable message describing the result of the operation. |
| `Data` | [`Week1`](../../doc/models/week-1.md) | Required | The data returned by the operation. |

## Example (as JSON)

```json
{
  "status": "OK",
  "message": "Operation completed successfully.",
  "data": {
    "weekId": 1234,
    "userId": "123e4567-e89b-12d3-a456-426614174000",
    "weekTitle": "Week 1: Foundation Building",
    "weekContent": "{\"monday\": {\"workoutId\": 101, \"notes\": \"Focus on form\"}, \"wednesday\": {\"workoutId\": 102, \"notes\": \"Increase weight if possible\"}, \"friday\": {\"workoutId\": 103, \"notes\": \"Cool down properly\"}}",
    "createdAt": "07/21/2023 15:30:00",
    "updatedAt": "07/22/2023 10:15:00",
    "deletedAt": "08/01/2023 09:00:00",
    "deletedBy": "987e6543-e21b-12d3-a456-426614174000",
    "weekThumbnail": {
      "mediaId": "0000005c-0000-0000-0000-000000000000",
      "fileName": "fileName8",
      "filePath": "filePath6",
      "fileUrl": "fileUrl8",
      "fileSize": 192,
      "fileFormat": "fileFormat0",
      "description": "description4"
    }
  }
}
```

