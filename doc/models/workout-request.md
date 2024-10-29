
# Workout Request

A new workout being created by POST - All fields optional

## Structure

`WorkoutRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `WorkoutTitle` | `string` | Optional | The title of the workout. |
| `WorkoutSlug` | `string` | Optional | The URL slug of the workout. |
| `WorkoutBackgroundImage` | [`MediaAsset`](../../doc/models/media-asset.md) | Optional | - |
| `CreatorCredits` | [`List<CreatorCredit>`](../../doc/models/creator-credit.md) | Optional | List of creator credits associated with this workout. |

## Example (as JSON)

```json
{
  "workoutTitle": "Full Body Strength Training",
  "workoutSlug": "full-body-strength-training",
  "workoutBackgroundImage": {
    "mediaId": "00001014-0000-0000-0000-000000000000",
    "fileName": "fileName2",
    "filePath": "filePath2",
    "fileUrl": "fileUrl2",
    "fileSize": 88,
    "fileFormat": "fileFormat4",
    "description": "description8"
  },
  "creatorCredits": [
    {
      "creatorProfileId": "00002506-0000-0000-0000-000000000000",
      "workoutSourceURL": "workoutSourceURL2",
      "contributionType": "ORIGINAL_AUTHOR",
      "creatorProfile": {
        "creatorProfileId": "00001068-0000-0000-0000-000000000000",
        "userId": "00001b82-0000-0000-0000-000000000000",
        "userName": "userName4",
        "firstName": "firstName8",
        "lastName": "lastName6"
      }
    },
    {
      "creatorProfileId": "00002506-0000-0000-0000-000000000000",
      "workoutSourceURL": "workoutSourceURL2",
      "contributionType": "ORIGINAL_AUTHOR",
      "creatorProfile": {
        "creatorProfileId": "00001068-0000-0000-0000-000000000000",
        "userId": "00001b82-0000-0000-0000-000000000000",
        "userName": "userName4",
        "firstName": "firstName8",
        "lastName": "lastName6"
      }
    },
    {
      "creatorProfileId": "00002506-0000-0000-0000-000000000000",
      "workoutSourceURL": "workoutSourceURL2",
      "contributionType": "ORIGINAL_AUTHOR",
      "creatorProfile": {
        "creatorProfileId": "00001068-0000-0000-0000-000000000000",
        "userId": "00001b82-0000-0000-0000-000000000000",
        "userName": "userName4",
        "firstName": "firstName8",
        "lastName": "lastName6"
      }
    }
  ]
}
```

