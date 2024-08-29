
# Equipment Group Translation 1

The data returned by the operation.

## Structure

`EquipmentGroupTranslation1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `LocaleCode` | `string` | Required | The locale code for this translation |
| `EquipmentGroupName` | `string` | Required | The translated name of the equipment group |
| `EquipmentGroupDescription` | `string` | Optional | The translated description of the equipment group |

## Example (as JSON)

```json
{
  "localeCode": "en-US",
  "equipmentGroupName": "Weightlifting Equipment",
  "equipmentGroupDescription": "Equipment used for weightlifting exercises"
}
```

