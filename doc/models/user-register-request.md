
# User Register Request

Data transfer object for user registration

## Structure

`UserRegisterRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Email` | `string` | Required | User's email address |
| `Password` | `string` | Required | User's password (should meet security requirements) |
| `FirstName` | `string` | Optional | User's first name |
| `LastName` | `string` | Optional | User's last name |
| `Username` | `string` | Required | User's chosen username |
| `RedirectUrl` | `string` | Optional | URL to redirect after successful registration |

## Example (as JSON)

```json
{
  "email": "john.doe@example.com",
  "password": "StrongP@ssw0rd!",
  "firstName": "John",
  "lastName": "Doe",
  "username": "johndoe123",
  "redirectUrl": "https://example.com/welcome"
}
```

