
# Exercise Categories Translations 404 Error Exception

## Structure

`ExerciseCategoriesTranslations404ErrorException`

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
  "message": "Exercise category not found",
  "errors": [
    "Exercise category with the specified code does not exist"
  ]
}
```

