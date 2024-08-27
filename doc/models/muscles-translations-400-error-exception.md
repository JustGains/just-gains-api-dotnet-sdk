
# Muscles Translations 400 Error Exception

## Structure

`MusclesTranslations400ErrorException`

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
  "message": "Failed to retrieve muscle translations",
  "errors": [
    "Invalid muscle code"
  ]
}
```

