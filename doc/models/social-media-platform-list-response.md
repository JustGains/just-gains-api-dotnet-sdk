
# Social Media Platform List Response

## Structure

`SocialMediaPlatformListResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `string` | Required | The status of the response, corresponding to standard HTTP status codes. |
| `Message` | `string` | Required | A human-readable message describing the result of the operation. |
| `Data` | [`List<SocialMediaPlatform>`](../../doc/models/social-media-platform.md) | Required | - |
| `Pagination` | [`Pagination`](../../doc/models/pagination.md) | Optional | - |

## Example (as JSON)

```json
{
  "status": "OK",
  "message": "Operation completed successfully.",
  "data": [
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
  ],
  "pagination": {
    "currentPage": 166,
    "totalPages": 154,
    "pageSize": 134,
    "totalCount": 250,
    "hasPrevious": false
  }
}
```

