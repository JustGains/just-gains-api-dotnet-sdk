
# Exercise Metric

Represents a metric associated with an exercise, including how it should be displayed.

## Structure

`ExerciseMetric`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ExerciseMetricCode` | `string` | Optional | A unique identifier for the exercise metric. |
| `ExerciseMetricTranslations` | [`List<ExerciseMetricTranslation>`](../../doc/models/exercise-metric-translation.md) | Optional | Array of translations for the metric |

## Example (as JSON)

```json
{
  "exerciseMetricCode": "WEIGHT",
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
    }
  ]
}
```

