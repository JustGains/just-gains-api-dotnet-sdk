
# Creator Profiles Response 1

## Structure

`CreatorProfilesResponse1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `string` | Required | - |
| `Message` | `string` | Required | - |
| `Data` | [`Data9`](../../doc/models/data-9.md) | Optional | - |

## Example (as JSON)

```json
{
  "status": "Created",
  "message": "Creator profile created successfully",
  "data": {
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
}
```

