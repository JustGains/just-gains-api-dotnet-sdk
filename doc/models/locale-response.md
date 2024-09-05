
# Locale Response

## Structure

`LocaleResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `string` | Required | The status of the response, corresponding to standard HTTP status codes. |
| `Message` | `string` | Required | A human-readable message describing the result of the operation. |
| `Data` | [`Locale`](../../doc/models/locale.md) | Required | - |

## Example (as JSON)

```json
{
  "status": "OK",
  "message": "Operation completed successfully.",
  "data": {
    "localeCode": "en-US",
    "localeName": "English (United States)",
    "published": true,
    "localeIcon": {
      "mediaId": "00000dd0-0000-0000-0000-000000000000",
      "fileName": "fileName2",
      "filePath": "filePath2",
      "fileUrl": "fileUrl2",
      "fileSize": 20,
      "fileFormat": "fileFormat4",
      "description": "description8"
    }
  }
}
```

