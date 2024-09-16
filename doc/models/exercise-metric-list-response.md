
# Exercise Metric List Response

## Structure

`ExerciseMetricListResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `string` | Required | The status of the response, corresponding to standard HTTP status codes. |
| `Message` | `string` | Required | A human-readable message describing the result of the operation. |
| `Data` | [`List<ExerciseMetricData>`](../../doc/models/exercise-metric-data.md) | Required | - |

## Example (as JSON)

```json
{
  "status": "OK",
  "message": "Operation completed successfully.",
  "data": [
    {
      "exerciseMetricCode": "WEIGHT",
      "metricName": "Weight",
      "measurementData": "{\r\n  \"unit\": \"lbs\",\r\n  \"precision\": 2\r\n}",
      "exerciseMetricTranslations": [
        {
          "localeCode": "localeCode6",
          "metricName": "metricName8",
          "measurementData": "measurementData4"
        },
        {
          "localeCode": "localeCode6",
          "metricName": "metricName8",
          "measurementData": "measurementData4"
        },
        {
          "localeCode": "localeCode6",
          "metricName": "metricName8",
          "measurementData": "measurementData4"
        }
      ]
    }
  ]
}
```

