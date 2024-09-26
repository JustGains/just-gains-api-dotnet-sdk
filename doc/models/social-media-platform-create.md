
# Social Media Platform Create

## Structure

`SocialMediaPlatformCreate`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `SocialMediaPlatformCode` | `string` | Required | Unique identifier for the social media platform |
| `SocialMediaPlatformName` | `string` | Required | Name of the social media platform |
| `SocialMediaPlatformUrlFormat` | `string` | Required | URL format for the platform's profile pages |
| `SocialMediaPlatformIcon` | `Guid?` | Optional | UUID of the associated MediaAsset for the platform's icon |

## Example (as JSON)

```json
{
  "socialMediaPlatformCode": "INSTAGRAM",
  "socialMediaPlatformName": "Instagram",
  "socialMediaPlatformUrlFormat": "https://www.instagram.com/{username}",
  "socialMediaPlatformIcon": "123e4567-e89b-12d3-a456-426614174000"
}
```

