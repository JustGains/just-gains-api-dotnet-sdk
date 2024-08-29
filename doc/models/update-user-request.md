
# Update User Request

Request object for updating user information

## Structure

`UpdateUserRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `User` | [`User`](../../doc/models/user.md) | Required | Represents a user in the system. |

## Example (as JSON)

```json
{
  "user": {
    "userId": "123e4567-e89b-12d3-a456-426614174000",
    "userName": "fitness_enthusiast_42",
    "email": "jane.doe@example.com",
    "password": "$2a$10$Ks6Qr5Yl.Y5iY5Z5Z5Z5Z5Z5Z5Z5Z5Z5Z5Z5Z5Z5Z5Z5Z5Z5Z5",
    "firstName": "Jane",
    "lastName": "Doe",
    "fullName": "Jane Doe",
    "oAuthProvider": "Google",
    "role": "user"
  }
}
```

