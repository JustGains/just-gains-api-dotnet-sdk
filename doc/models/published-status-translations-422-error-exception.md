
# Published Status Translations 422 Error Exception

## Structure

`PublishedStatusTranslations422ErrorException`

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
  "message": "Failed to process the request",
  "errors": [
    "Invalid locale code",
    "Duplicate translations for the same locale"
  ]
}
```

