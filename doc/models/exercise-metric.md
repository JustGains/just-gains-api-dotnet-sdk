
# Exercise Metric

Represents a metric associated with an exercise, including how it should be displayed.

## Structure

`ExerciseMetric`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ExerciseMetricCode` | `string` | Optional | A unique identifier for the exercise metric. |
| `ExerciseMetricName` | `string` | Optional | Translated name of the metric (Realistically not used because the real data for this comes from measurementData) |
| `MeasurementData` | [`MeasurementData`](../../doc/models/measurement-data.md) | Optional | - |

## Example (as JSON)

```json
{
  "exerciseMetricCode": "WEIGHT",
  "exerciseMetricName": "exerciseMetricName6",
  "measurementData": {
    "metricCode": "metricCode4",
    "displayName": "displayName2",
    "units": {
      "metricUnits": {
        "units": [
          {
            "unitCode": "unitCode0",
            "unitShort": {
              "unitShortName": "unitShortName4",
              "unitShortPlural": "unitShortPlural8"
            },
            "unitLong": {
              "unitLongName": "unitLongName4",
              "unitLongPlural": "unitLongPlural6"
            },
            "conversionFactor": 5.06
          }
        ],
        "defaultUnit": 88
      },
      "imperialUnits": {
        "units": [
          {
            "unitCode": "unitCode0",
            "unitShort": {
              "unitShortName": "unitShortName4",
              "unitShortPlural": "unitShortPlural8"
            },
            "unitLong": {
              "unitLongName": "unitLongName4",
              "unitLongPlural": "unitLongPlural6"
            },
            "conversionFactor": 5.06
          },
          {
            "unitCode": "unitCode0",
            "unitShort": {
              "unitShortName": "unitShortName4",
              "unitShortPlural": "unitShortPlural8"
            },
            "unitLong": {
              "unitLongName": "unitLongName4",
              "unitLongPlural": "unitLongPlural6"
            },
            "conversionFactor": 5.06
          }
        ],
        "defaultUnit": 12
      }
    },
    "displayFormat": "displayFormat8",
    "inputType": "inputType0"
  }
}
```

