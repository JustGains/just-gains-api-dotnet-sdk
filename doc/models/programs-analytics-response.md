
# Programs Analytics Response

## Structure

`ProgramsAnalyticsResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `string` | Required | - |
| `Message` | `string` | Required | - |
| `Data` | [`Data72`](../../doc/models/data-72.md) | Optional | - |

## Example (as JSON)

```json
{
  "status": "OK",
  "message": "Program analytics retrieved successfully",
  "data": {
    "analyticsId": 196,
    "programId": 152,
    "startCount": 248,
    "completionCount": 246,
    "averageRating": 114.64
  }
}
```

