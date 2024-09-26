
# Update User Request

## Structure

`UpdateUserRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `UserId` | `Guid?` | Optional | Unique identifier for the user. |
| `Email` | `string` | Optional | The user's email address. |
| `FirstName` | `string` | Optional | The user's first name. |
| `LastName` | `string` | Optional | The user's last name. |
| `FullName` | `string` | Optional | The user's full name, typically a combination of first and last name. |

## Example (as JSON)

```json
{
  "userId": "123e4567-e89b-12d3-a456-426614174000",
  "email": "jane.doe@example.com",
  "firstName": "Jane",
  "lastName": "Doe",
  "fullName": "Jane Doe"
}
```

