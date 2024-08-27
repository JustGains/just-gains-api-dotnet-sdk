
# Auth Signup 400 Error Exception

## Structure

`AuthSignup400ErrorException`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `string` | Required | - |
| `Message` | `string` | Required | - |
| `Errors` | `List<string>` | Optional | - |

## Example (as JSON)

```json
{
  "status": "Bad Request",
  "message": "Registration failed",
  "errors": [
    "Invalid email format",
    "Password too weak"
  ]
}
```

