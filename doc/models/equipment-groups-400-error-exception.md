
# Equipment Groups 400 Error Exception

## Structure

`EquipmentGroups400ErrorException`

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
  "message": "Invalid request parameters",
  "errors": [
    "Invalid locale code"
  ]
}
```

