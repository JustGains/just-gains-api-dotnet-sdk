
# User Response

## Structure

`UserResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `string` | Required | The status of the response, corresponding to standard HTTP status codes. |
| `Message` | `string` | Required | A human-readable message describing the result of the operation. |
| `Data` | [`Data`](../../doc/models/data.md) | Required | - |

## Example (as JSON)

```json
{
  "status": "OK",
  "message": "Operation completed successfully.",
  "data": {
    "userId": "123e4567-e89b-12d3-a456-426614174000",
    "userName": "fitness_enthusiast_42",
    "email": "jane.doe@example.com",
    "password": "$2a$10$Ks6Qr5Yl.Y5iY5Z5Z5Z5Z5Z5Z5Z5Z5Z5Z5Z5Z5Z5Z5Z5Z5Z5Z5",
    "firstName": "Jane",
    "lastName": "Doe",
    "fullName": "Jane Doe",
    "oAuthProvider": "Google",
    "roles": [
      "user"
    ]
  }
}
```

