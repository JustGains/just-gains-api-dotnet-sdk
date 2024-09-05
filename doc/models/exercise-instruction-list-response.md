
# Exercise Instruction List Response

## Structure

`ExerciseInstructionListResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `string` | Required | The status of the response, corresponding to standard HTTP status codes. |
| `Message` | `string` | Required | A human-readable message describing the result of the operation. |
| `Data` | [`List<ExerciseInstructionListItem>`](../../doc/models/exercise-instruction-list-item.md) | Required | - |
| `Pagination` | [`Pagination`](../../doc/models/pagination.md) | Optional | - |

## Example (as JSON)

```json
{
  "status": "OK",
  "message": "Operation completed successfully.",
  "data": [
    {
      "userId": "9fdd12f5-c7b9-82a8-f6cc-cceac14c13c1",
      "localeCode": "en-US",
      "dateUpdated": "2023-07-10T11:45:00Z",
      "dateCreated": "2023-06-15T08:30:00Z"
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

