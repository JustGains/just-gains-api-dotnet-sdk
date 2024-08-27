
# Locales Response

## Structure

`LocalesResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `string` | Required | - |
| `Message` | `string` | Required | - |
| `Data` | [`Locale`](../../doc/models/locale.md) | Optional | - |

## Example (as JSON)

```json
{
  "status": "OK",
  "message": "Locales retrieved successfully",
  "data": {
    "localeCode": "localeCode2",
    "localeName": "localeName8",
    "published": false,
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

