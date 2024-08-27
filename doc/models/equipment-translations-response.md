
# Equipment Translations Response

## Structure

`EquipmentTranslationsResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `string` | Required | - |
| `Message` | `string` | Required | - |
| `Data` | [`Data46`](../../doc/models/data-46.md) | Optional | - |

## Example (as JSON)

```json
{
  "status": "OK",
  "message": "Equipment translations retrieved successfully",
  "data": {
    "localeCode": "localeCode2",
    "equipmentName": "equipmentName0"
  }
}
```

