
# Program Analytics Response

## Structure

`ProgramAnalyticsResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `string` | Required | The status of the response, corresponding to standard HTTP status codes. |
| `Message` | `string` | Required | A human-readable message describing the result of the operation. |
| `Data` | [`ProgramAnalytics`](../../doc/models/program-analytics.md) | Required | Contains analytics data for a specific program. |

## Example (as JSON)

```json
{
  "status": "OK",
  "message": "Operation completed successfully.",
  "data": {
    "analyticsId": 5001,
    "programId": 1001,
    "startCount": 1500,
    "completionCount": 1200,
    "averageRating": 4.7,
    "lastUpdated": "07/30/2023 23:59:59"
  }
}
```

