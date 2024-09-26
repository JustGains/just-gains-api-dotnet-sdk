
# Social Media Platform Response

## Structure

`SocialMediaPlatformResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `string` | Required | The status of the response, corresponding to standard HTTP status codes. |
| `Message` | `string` | Required | A human-readable message describing the result of the operation. |
| `Data` | [`SocialMediaPlatform`](../../doc/models/social-media-platform.md) | Required | - |

## Example (as JSON)

```json
{
  "status": "OK",
  "message": "Operation completed successfully.",
  "data": {
    "socialMediaPlatformCode": "TWITTER",
    "socialMediaPlatformName": "Twitter",
    "socialMediaPlatformUrlFormat": "https://twitter.com/{username}",
    "socialMediaPlatformIcon": "123e4567-e89b-12d3-a456-426614174000"
  }
}
```

