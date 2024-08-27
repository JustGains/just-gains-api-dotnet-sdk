
# Equipment Groups Translations 400 Error Exception

## Structure

`EquipmentGroupsTranslations400ErrorException`

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
  "message": "Failed to retrieve equipment group translations",
  "errors": [
    "Invalid equipment group code"
  ]
}
```

