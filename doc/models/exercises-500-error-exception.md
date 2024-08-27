
# Exercises 500 Error Exception

## Structure

`Exercises500ErrorException`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `string` | Required | - |
| `Message` | `string` | Required | - |
| `Errors` | `List<string>` | Optional | - |

## Example (as JSON)

```json
{
  "status": "Internal Server Error",
  "message": "Failed to update exercise",
  "errors": [
    "Internal server error"
  ]
}
```

