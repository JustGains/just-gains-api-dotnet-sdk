
# Locale 1

The data returned by the operation.

## Structure

`Locale1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `LocaleCode` | `string` | Optional | A unique code for the locale. |
| `LocaleName` | `string` | Optional | The name of the locale. |
| `Published` | `bool?` | Optional | Indicates whether the locale is published. |
| `LocaleIcon` | [`MediaAsset`](../../doc/models/media-asset.md) | Optional | - |

## Example (as JSON)

```json
{
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
```

