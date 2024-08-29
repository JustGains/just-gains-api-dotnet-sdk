
# Program Review Response

## Structure

`ProgramReviewResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `string` | Required | The status of the response, corresponding to standard HTTP status codes. |
| `Message` | `string` | Required | A human-readable message describing the result of the operation. |
| `Data` | [`ProgramReview1`](../../doc/models/program-review-1.md) | Required | The data returned by the operation. |

## Example (as JSON)

```json
{
  "status": "OK",
  "message": "Operation completed successfully.",
  "data": {
    "reviewId": 20001,
    "programId": 1001,
    "userId": "123e4567-e89b-12d3-a456-426614174000",
    "rating": 5,
    "reviewText": "This program significantly improved my strength. Highly recommended for intermediate lifters!",
    "createdAt": "07/28/2023 18:45:00"
  }
}
```

