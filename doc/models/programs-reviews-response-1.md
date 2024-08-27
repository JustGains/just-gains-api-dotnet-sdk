
# Programs Reviews Response 1

## Structure

`ProgramsReviewsResponse1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `string` | Required | - |
| `Message` | `string` | Required | - |
| `Data` | [`Data75`](../../doc/models/data-75.md) | Optional | - |

## Example (as JSON)

```json
{
  "status": "Created",
  "message": "Review added successfully",
  "data": {
    "reviewId": 46,
    "programId": 152,
    "userId": "000018a6-0000-0000-0000-000000000000",
    "rating": 114,
    "reviewText": "reviewText8"
  }
}
```

