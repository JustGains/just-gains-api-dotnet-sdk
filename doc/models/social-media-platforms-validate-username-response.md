
# Social Media Platforms Validate Username Response

## Structure

`SocialMediaPlatformsValidateUsernameResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `string` | Required | The status of the response, corresponding to standard HTTP status codes. |
| `Message` | `string` | Required | A human-readable message describing the result of the operation. |
| `Data` | [`Data2`](../../doc/models/data-2.md) | Required | - |

## Example (as JSON)

```json
{
  "status": "OK",
  "message": "Operation completed successfully.",
  "data": {
    "isAvailable": true,
    "isValid": true,
    "validation": "Valid",
    "creatorProfileId": "123e4567-e89b-12d3-a456-426614174000"
  }
}
```

