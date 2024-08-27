
# Exercises Translations 404 Error Exception

## Structure

`ExercisesTranslations404ErrorException`

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
  "message": "Exercise translations not found",
  "errors": [
    "No translations found for the specified exercise code"
  ]
}
```

