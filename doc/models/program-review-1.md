
# Program Review 1

The data returned by the operation.

## Structure

`ProgramReview1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ReviewId` | `int` | Required | Unique identifier for this review. |
| `ProgramId` | `int` | Required | Identifier of the reviewed program. |
| `UserId` | `Guid` | Required | Identifier of the user who wrote the review. |
| `Rating` | `int` | Required | Numeric rating given by the user (1 to 5).<br>**Constraints**: `>= 1`, `<= 5` |
| `ReviewText` | `string` | Optional | Text content of the review. |
| `CreatedAt` | `DateTime` | Required | Timestamp of when the review was created. |

## Example (as JSON)

```json
{
  "reviewId": 20001,
  "programId": 1001,
  "userId": "123e4567-e89b-12d3-a456-426614174000",
  "rating": 5,
  "reviewText": "This program significantly improved my strength. Highly recommended for intermediate lifters!",
  "createdAt": "07/28/2023 18:45:00"
}
```

