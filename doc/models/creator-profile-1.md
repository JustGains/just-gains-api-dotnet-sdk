
# Creator Profile 1

## Structure

`CreatorProfile1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CreatorProfileId` | `Guid?` | Optional | Unique identifier for the creator profile. |
| `UserId` | `Guid?` | Optional | Associated user ID, if applicable. |
| `UserName` | `string` | Optional | Creator's username. |
| `FirstName` | `string` | Optional | Creator's first name. |
| `LastName` | `string` | Optional | Creator's last name. |
| `FullName` | `string` | Optional | Creator's full name. |
| `ProfilePhoto` | [`MediaAsset`](../../doc/models/media-asset.md) | Optional | - |
| `SocialMediaAccounts` | [`List<CreatorSocialMediaAccount>`](../../doc/models/creator-social-media-account.md) | Optional | List of creator's social media accounts. |

## Example (as JSON)

```json
{
  "creatorProfileId": "123e4567-e89b-12d3-a456-426614174000",
  "userId": "123e4567-e89b-12d3-a456-426614174000",
  "userName": "TheRock",
  "firstName": "Dwayne",
  "lastName": "Johnson",
  "fullName": "Dwayne Johnson"
}
```

