
# Exercise Category Translation

Represents a translation of an exercise category name for a specific locale.

## Structure

`ExerciseCategoryTranslation`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `LocaleCode` | `string` | Required | The locale code for this translation (e.g., 'en-US', 'es-ES'). |
| `ExerciseCategoryName` | `string` | Required | The translated name of the exercise category in the specified locale. |

## Example (as JSON)

```json
{
  "localeCode": "en-US",
  "exerciseCategoryName": "Strength Training"
}
```

