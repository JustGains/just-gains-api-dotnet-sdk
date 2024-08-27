
# Exercise Metrics Response 1

## Structure

`ExerciseMetricsResponse1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `string` | Required | - |
| `Message` | `string` | Required | - |
| `Data` | [`Data34`](../../doc/models/data-34.md) | Optional | - |

## Example (as JSON)

```json
{
  "status": "Created",
  "message": "Exercise metric created successfully",
  "data": {
    "exerciseMetricCode": "exerciseMetricCode0",
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
}
```

