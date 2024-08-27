
# Data 12

## Structure

`Data12`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `Guid?` | Optional | Unique identifier for the user |
| `Email` | `string` | Optional | User's email address |
| `UserName` | `string` | Optional | User's username |
| `FirstName` | `string` | Optional | The user's first name. |
| `LastName` | `string` | Optional | The user's last name. |
| `EmailConfirmed` | `bool?` | Optional | Indicates if the user's email has been confirmed |
| `Roles` | `List<string>` | Optional | List of roles assigned to the user |
| `LastLoginAt` | `DateTime?` | Optional | Timestamp of the user's last login |

## Example (as JSON)

```json
{
  "id": "123e4567-e89b-12d3-a456-426614174000",
  "email": "john.doe@example.com",
  "userName": "johndoe123",
  "firstName": "Jane",
  "lastName": "Doe",
  "emailConfirmed": true,
  "roles": [
    "user",
    "admin"
  ],
  "lastLoginAt": "06/14/2023 09:30:00"
}
```

