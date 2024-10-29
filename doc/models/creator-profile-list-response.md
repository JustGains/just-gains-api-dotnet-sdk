
# Creator Profile List Response

## Structure

`CreatorProfileListResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `string` | Required | The status of the response, corresponding to standard HTTP status codes. |
| `Message` | `string` | Required | A human-readable message describing the result of the operation. |
| `Data` | [`List<CreatorProfile>`](../../doc/models/creator-profile.md) | Required | - |
| `Pagination` | [`Pagination`](../../doc/models/pagination.md) | Optional | - |

## Example (as JSON)

```json
{
  "status": "OK",
  "message": "Operation completed successfully.",
  "data": [
    {
      "creatorProfileId": "123e4567-e89b-12d3-a456-426614174000",
      "userId": "123e4567-e89b-12d3-a456-426614174000",
      "userName": "TheRock",
      "firstName": "Dwayne",
      "lastName": "Johnson",
      "fullName": "Dwayne Johnson"
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

