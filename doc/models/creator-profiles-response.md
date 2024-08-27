
# Creator Profiles Response

## Structure

`CreatorProfilesResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `string` | Required | - |
| `Message` | `string` | Required | - |
| `Data` | [`List<CreatorProfile>`](../../doc/models/creator-profile.md) | Optional | - |
| `Pagination` | [`Pagination`](../../doc/models/pagination.md) | Optional | - |

## Example (as JSON)

```json
{
  "status": "OK",
  "message": "Creator profiles retrieved successfully 💪",
  "data": [
    {
      "creatorProfileId": "00000d8c-0000-0000-0000-000000000000",
      "userId": "000018a6-0000-0000-0000-000000000000",
      "creatorEmail": "creatorEmail8",
      "profilePhoto": {
        "mediaId": "000006b6-0000-0000-0000-000000000000",
        "fileName": "fileName4",
        "filePath": "filePath0",
        "fileUrl": "fileUrl4",
        "fileSize": 10,
        "fileFormat": "fileFormat6",
        "description": "description0"
      },
      "socialMediaAccounts": [
        {
          "socialMediaPlatformCode": "socialMediaPlatformCode8",
          "socialMediaAccountUsername": "socialMediaAccountUsername8"
        },
        {
          "socialMediaPlatformCode": "socialMediaPlatformCode8",
          "socialMediaAccountUsername": "socialMediaAccountUsername8"
        }
      ]
    },
    {
      "creatorProfileId": "00000d8c-0000-0000-0000-000000000000",
      "userId": "000018a6-0000-0000-0000-000000000000",
      "creatorEmail": "creatorEmail8",
      "profilePhoto": {
        "mediaId": "000006b6-0000-0000-0000-000000000000",
        "fileName": "fileName4",
        "filePath": "filePath0",
        "fileUrl": "fileUrl4",
        "fileSize": 10,
        "fileFormat": "fileFormat6",
        "description": "description0"
      },
      "socialMediaAccounts": [
        {
          "socialMediaPlatformCode": "socialMediaPlatformCode8",
          "socialMediaAccountUsername": "socialMediaAccountUsername8"
        },
        {
          "socialMediaPlatformCode": "socialMediaPlatformCode8",
          "socialMediaAccountUsername": "socialMediaAccountUsername8"
        }
      ]
    },
    {
      "creatorProfileId": "00000d8c-0000-0000-0000-000000000000",
      "userId": "000018a6-0000-0000-0000-000000000000",
      "creatorEmail": "creatorEmail8",
      "profilePhoto": {
        "mediaId": "000006b6-0000-0000-0000-000000000000",
        "fileName": "fileName4",
        "filePath": "filePath0",
        "fileUrl": "fileUrl4",
        "fileSize": 10,
        "fileFormat": "fileFormat6",
        "description": "description0"
      },
      "socialMediaAccounts": [
        {
          "socialMediaPlatformCode": "socialMediaPlatformCode8",
          "socialMediaAccountUsername": "socialMediaAccountUsername8"
        },
        {
          "socialMediaPlatformCode": "socialMediaPlatformCode8",
          "socialMediaAccountUsername": "socialMediaAccountUsername8"
        }
      ]
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

