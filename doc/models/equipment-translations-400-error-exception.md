
# Equipment Translations 400 Error Exception

## Structure

`EquipmentTranslations400ErrorException`

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
  "message": "Failed to retrieve equipment translations",
  "errors": [
    "Invalid equipment code"
  ]
}
```

