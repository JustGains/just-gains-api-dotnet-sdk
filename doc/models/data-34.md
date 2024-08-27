
# Data 34

## Structure

`Data34`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ExerciseMetricCode` | `string` | Optional | A unique identifier for the exercise metric. |
| `ExerciseMetricName` | `string` | Optional | Translated name of the metric (Realistically not used because the real data for this comes from measurementData) |
| `ExerciseMetricTranslations` | [`List<ExerciseMetricTranslation>`](../../doc/models/exercise-metric-translation.md) | Optional | - |
| `MeasurementData` | [`MeasurementData`](../../doc/models/measurement-data.md) | Optional | - |

## Example (as JSON)

```json
{
  "exerciseMetricCode": "WEIGHT",
  "exerciseMetricName": "exerciseMetricName0",
  "exerciseMetricTranslations": [
    {
      "localeCode": "localeCode6",
      "exerciseMetricName": "exerciseMetricName4",
      "measurementData": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    {
      "localeCode": "localeCode6",
      "exerciseMetricName": "exerciseMetricName4",
      "measurementData": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    {
      "localeCode": "localeCode6",
      "exerciseMetricName": "exerciseMetricName4",
      "measurementData": {
        "key1": "val1",
        "key2": "val2"
      }
    }
  ],
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

