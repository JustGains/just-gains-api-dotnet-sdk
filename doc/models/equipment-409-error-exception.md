
# Equipment 409 Error Exception

## Structure

`Equipment409ErrorException`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `string` | Required | - |
| `Message` | `string` | Required | - |
| `Errors` | `List<string>` | Optional | - |

## Example (as JSON)

```json
{
  "status": "Unknown Status",
  "message": "Equipment code conflict",
  "errors": [
    "Equipment code already exists for a different equipment"
  ]
}
```

