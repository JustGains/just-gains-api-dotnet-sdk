
# Social Media Platform

## Structure

`SocialMediaPlatform`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `SocialMediaPlatformCode` | `string` | Optional | Unique identifier for the social media platform |
| `SocialMediaPlatformName` | `string` | Optional | Name of the social media platform |
| `SocialMediaPlatformUrlFormat` | `string` | Optional | URL format for the platform's profile pages |
| `SocialMediaPlatformIcon` | `Guid?` | Optional | UUID of the associated MediaAsset for the platform's icon |

## Example (as JSON)

```json
{
  "socialMediaPlatformCode": "TWITTER",
  "socialMediaPlatformName": "Twitter",
  "socialMediaPlatformUrlFormat": "https://twitter.com/{username}",
  "socialMediaPlatformIcon": "123e4567-e89b-12d3-a456-426614174000"
}
```

