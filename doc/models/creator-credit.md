
# Creator Credit

Represents a creator credit for a workout.

## Structure

`CreatorCredit`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CreatorProfileId` | `Guid?` | Optional | Unique identifier for the creator profile. |
| `WorkoutSourceURL` | `string` | Optional | URL source of the workout, if applicable. |
| `ContributionType` | [`ContributionTypeEnum?`](../../doc/models/contribution-type-enum.md) | Optional | Type of contribution made by the creator. |
| `CreatorProfile` | [`CreatorProfile`](../../doc/models/creator-profile.md) | Optional | Represents a creator's profile information. |

## Example (as JSON)

```json
{
  "creatorProfileId": "d290f1ee-6c54-4b01-90e6-d701748f0851",
  "workoutSourceURL": "https://www.example.com/workout",
  "contributionType": "ORIGINAL_AUTHOR",
  "creatorProfile": {
    "creatorProfileId": "00001068-0000-0000-0000-000000000000",
    "userId": "00001b82-0000-0000-0000-000000000000",
    "userName": "userName4",
    "creatorEmail": "creatorEmail0",
    "profilePhoto": {
      "mediaId": "000006b6-0000-0000-0000-000000000000",
      "fileName": "fileName4",
      "filePath": "filePath0",
      "fileUrl": "fileUrl4",
      "fileSize": 10,
      "fileFormat": "fileFormat6",
      "description": "description0"
    }
  }
}
```

