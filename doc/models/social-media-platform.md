
# Social Media Platform

## Structure

`SocialMediaPlatform`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `SocialMediaPlatformCode` | `string` | Optional | Unique identifier for the social media platform |
| `SocialMediaPlatformName` | `string` | Optional | Name of the social media platform |
| `SocialMediaPlatformUrlFormat` | `string` | Optional | URL format for the platform's profile pages |
| `SocialMediaPlatformIcon` | [`MediaAsset`](../../doc/models/media-asset.md) | Optional | - |

## Example (as JSON)

```json
{
  "socialMediaPlatformCode": "TWITTER",
  "socialMediaPlatformName": "Twitter",
  "socialMediaPlatformUrlFormat": "https://twitter.com/{username}",
  "socialMediaPlatformIcon": {
    "mediaId": "000004fe-0000-0000-0000-000000000000",
    "fileName": "fileName4",
    "filePath": "filePath0",
    "fileUrl": "fileUrl4",
    "fileSize": 18,
    "fileFormat": "fileFormat6",
    "description": "description0"
  }
}
```

