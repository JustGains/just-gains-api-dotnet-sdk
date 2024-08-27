
# Exercises Translations 422 Error Exception

## Structure

`ExercisesTranslations422ErrorException`

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
  "message": "Validation error",
  "errors": [
    "Invalid locale code",
    "Translation text is required"
  ]
}
```

