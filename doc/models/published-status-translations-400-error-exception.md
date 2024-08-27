
# Published Status Translations 400 Error Exception

## Structure

`PublishedStatusTranslations400ErrorException`

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
  "message": "Failed to retrieve published status translations",
  "errors": [
    "Invalid published status code"
  ]
}
```

