
# Exercise Metric Translation

## Structure

`ExerciseMetricTranslation`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `LocaleCode` | `string` | Required | The locale code of the translation |
| `ExerciseMetricName` | `string` | Required | Translated Metric Name for the chosen Locale |
| `MeasurementData` | `object` | Required | JSONB format containing measurement details |

## Example (as JSON)

```json
{
  "localeCode": "en-US",
  "exerciseMetricName": "exerciseMetricName4",
  "measurementData": {
    "unit": "kg",
    "unitType": "weight",
    "unitPrecision": 2
  }
}
```

