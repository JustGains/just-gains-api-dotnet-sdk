
# Users Response 1

## Structure

`UsersResponse1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `string` | Required | - |
| `Message` | `string` | Required | - |
| `Data` | [`Data6`](../../doc/models/data-6.md) | Optional | - |

## Example (as JSON)

```json
{
  "status": "OK",
  "message": "User retrieved successfully",
  "data": {
    "userId": "000018a6-0000-0000-0000-000000000000",
    "userName": "userName2",
    "email": "email6",
    "password": "password4",
    "firstName": "firstName6"
  }
}
```

