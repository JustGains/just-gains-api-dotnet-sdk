
# Auth Reset Password 400 Error Exception

## Structure

`AuthResetPassword400ErrorException`

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
  "message": "Failed to reset password",
  "errors": [
    "Invalid or expired reset token"
  ]
}
```

