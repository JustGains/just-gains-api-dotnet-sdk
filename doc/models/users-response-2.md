
# Users Response 2

## Structure

`UsersResponse2`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `string` | Required | - |
| `Message` | `string` | Required | - |
| `Data` | [`Data7`](../../doc/models/data-7.md) | Optional | - |

## Example (as JSON)

```json
{
  "status": "OK",
  "message": "User updated successfully",
  "data": {
    "userId": "000018a6-0000-0000-0000-000000000000",
    "userName": "userName2",
    "email": "email6",
    "password": "password4",
    "firstName": "firstName6"
  }
}
```

