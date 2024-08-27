
# Users 403 Error Exception

## Structure

`Users403ErrorException`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `string` | Required | - |
| `Message` | `string` | Required | - |
| `Errors` | `List<string>` | Optional | - |

## Example (as JSON)

```json
{
  "status": "Forbidden",
  "message": "Access denied",
  "errors": [
    "User does not have the required role to access this resource"
  ]
}
```

