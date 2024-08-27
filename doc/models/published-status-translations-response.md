
# Published Status Translations Response

## Structure

`PublishedStatusTranslationsResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `string` | Required | - |
| `Message` | `string` | Required | - |
| `Data` | [`PublishedStatusTranslation`](../../doc/models/published-status-translation.md) | Optional | - |

## Example (as JSON)

```json
{
  "status": "OK",
  "message": "Published status translations retrieved successfully",
  "data": {
    "localeCode": "localeCode2",
    "publishedStatusName": "publishedStatusName4"
  }
}
```

