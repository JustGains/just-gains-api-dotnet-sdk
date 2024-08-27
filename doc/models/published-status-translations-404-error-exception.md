
# Published Status Translations 404 Error Exception

## Structure

`PublishedStatusTranslations404ErrorException`

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
  "message": "Published status not found",
  "errors": [
    "The requested published status could not be found"
  ]
}
```

