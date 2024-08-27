
# Users Response

## Structure

`UsersResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `string` | Required | - |
| `Message` | `string` | Required | - |
| `Data` | [`List<User>`](../../doc/models/user.md) | Optional | - |
| `Pagination` | [`Pagination`](../../doc/models/pagination.md) | Optional | - |

## Example (as JSON)

```json
{
  "status": "OK",
  "message": "Users retrieved successfully",
  "data": [
    {
      "userId": "000018a6-0000-0000-0000-000000000000",
      "userName": "userName2",
      "email": "email6",
      "password": "password4",
      "firstName": "firstName6"
    },
    {
      "userId": "000018a6-0000-0000-0000-000000000000",
      "userName": "userName2",
      "email": "email6",
      "password": "password4",
      "firstName": "firstName6"
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

