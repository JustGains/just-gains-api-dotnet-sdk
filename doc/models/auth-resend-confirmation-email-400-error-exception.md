
# Auth Resend Confirmation Email 400 Error Exception

## Structure

`AuthResendConfirmationEmail400ErrorException`

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
  "message": "Failed to send confirmation email",
  "errors": [
    "Invalid email address"
  ]
}
```

