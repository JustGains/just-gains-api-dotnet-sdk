
# Muscles Translations 404 Error Exception

## Structure

`MusclesTranslations404ErrorException`

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
  "message": "Muscle not found",
  "errors": [
    "The requested muscle could not be found"
  ]
}
```

