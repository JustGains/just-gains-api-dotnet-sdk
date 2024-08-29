
# Creator Profile Response

## Structure

`CreatorProfileResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `string` | Required | The status of the response, corresponding to standard HTTP status codes. |
| `Message` | `string` | Required | A human-readable message describing the result of the operation. |
| `Data` | [`CreatorProfile1`](../../doc/models/creator-profile-1.md) | Required | The data returned by the operation. |

## Example (as JSON)

```json
{
  "status": "OK",
  "message": "Operation completed successfully.",
  "data": {
    "creatorProfileId": "123e4567-e89b-12d3-a456-426614174000",
    "userId": "123e4567-e89b-12d3-a456-426614174000",
    "creatorEmail": "dwayne@therockjohnson.com",
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

