
# Programs Reviews Response

## Structure

`ProgramsReviewsResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `string` | Required | - |
| `Message` | `string` | Required | - |
| `Data` | [`List<ProgramReview>`](../../doc/models/program-review.md) | Optional | - |

## Example (as JSON)

```json
{
  "status": "OK",
  "message": "Program reviews retrieved successfully",
  "data": [
    {
      "reviewId": 46,
      "programId": 152,
      "userId": "000018a6-0000-0000-0000-000000000000",
      "rating": 114,
      "reviewText": "reviewText8",
      "createdAt": "2016-03-13T12:52:32.123Z"
    }
  ]
}
```

