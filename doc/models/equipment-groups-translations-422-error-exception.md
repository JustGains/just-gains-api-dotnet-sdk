
# Equipment Groups Translations 422 Error Exception

## Structure

`EquipmentGroupsTranslations422ErrorException`

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
  "message": "Failed to update equipment group translations",
  "errors": [
    "Invalid locale code"
  ]
}
```

