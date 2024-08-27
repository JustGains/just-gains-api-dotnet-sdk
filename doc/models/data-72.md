
# Data 72

## Structure

`Data72`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AnalyticsId` | `int?` | Optional | Unique identifier for this analytics entry. |
| `ProgramId` | `int?` | Optional | Identifier of the program these analytics belong to. |
| `StartCount` | `int?` | Optional | Number of times the program has been started by users. |
| `CompletionCount` | `int?` | Optional | Number of times the program has been completed by users. |
| `AverageRating` | `double?` | Optional | Average rating of the program (typically out of 5). |
| `LastUpdated` | `DateTime?` | Optional | Timestamp of when these analytics were last updated. |

## Example (as JSON)

```json
{
  "analyticsId": 5001,
  "programId": 1001,
  "startCount": 1500,
  "completionCount": 1200,
  "averageRating": 4.7,
  "lastUpdated": "07/30/2023 23:59:59"
}
```

