
# Users 401 Error Exception

## Structure

`Users401ErrorException`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `string` | Required | - |
| `Message` | `string` | Required | - |
| `Errors` | `List<string>` | Optional | - |

## Example (as JSON)

```json
{
  "status": "Unauthorized",
  "message": "Authentication required",
  "errors": [
    "Invalid or expired token"
  ]
}
```

