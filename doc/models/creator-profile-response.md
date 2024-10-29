
# Creator Profile Response

## Structure

`CreatorProfileResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `string` | Required | The status of the response, corresponding to standard HTTP status codes. |
| `Message` | `string` | Required | A human-readable message describing the result of the operation. |
| `Data` | [`CreatorProfile`](../../doc/models/creator-profile.md) | Required | Represents a creator's profile information. |

## Example (as JSON)

```json
{
  "status": "OK",
  "message": "Operation completed successfully.",
  "data": {
    "creatorProfileId": "123e4567-e89b-12d3-a456-426614174000",
    "userId": "123e4567-e89b-12d3-a456-426614174000",
    "userName": "TheRock",
    "firstName": "Dwayne",
    "lastName": "Johnson",
    "fullName": "Dwayne Johnson"
  }
}
```

