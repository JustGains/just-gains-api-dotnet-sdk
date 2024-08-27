
# Equipment Groups 404 Error Exception

## Structure

`EquipmentGroups404ErrorException`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `string` | Required | - |
| `Message` | `string` | Required | - |
| `Errors` | `List<string>` | Optional | - |

## Example (as JSON)

```json
{
  "status": "Not Found",
  "message": "Equipment group not found",
  "errors": [
    "Equipment group with the specified code does not exist"
  ]
}
```

