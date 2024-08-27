
# Exercise Categories Translations 400 Error Exception

## Structure

`ExerciseCategoriesTranslations400ErrorException`

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
  "message": "Failed to retrieve exercise category translations",
  "errors": [
    "Invalid exercise category code"
  ]
}
```

