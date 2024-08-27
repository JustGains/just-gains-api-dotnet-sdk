
# User Login Request

Data transfer object for user login

## Structure

`UserLoginRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Email` | `string` | Required | User's email address |
| `Password` | `string` | Required | User's password |

## Example (as JSON)

```json
{
  "email": "john.doe@example.com",
  "password": "StrongP@ssw0rd!"
}
```

