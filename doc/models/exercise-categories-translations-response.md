
# Exercise Categories Translations Response

## Structure

`ExerciseCategoriesTranslationsResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `string` | Required | - |
| `Message` | `string` | Required | - |
| `Data` | [`List<ExerciseCategoryTranslation>`](../../doc/models/exercise-category-translation.md) | Optional | - |

## Example (as JSON)

```json
{
  "status": "OK",
  "message": "Exercise category translations retrieved successfully",
  "data": [
    {
      "localeCode": "localeCode2",
      "exerciseCategoryName": "exerciseCategoryName2"
    },
    {
      "localeCode": "localeCode2",
      "exerciseCategoryName": "exerciseCategoryName2"
    },
    {
      "localeCode": "localeCode2",
      "exerciseCategoryName": "exerciseCategoryName2"
    }
  ]
}
```

