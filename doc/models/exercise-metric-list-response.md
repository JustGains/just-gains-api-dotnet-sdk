
# Exercise Metric List Response

## Structure

`ExerciseMetricListResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `string` | Required | The status of the response, corresponding to standard HTTP status codes. |
| `Message` | `string` | Required | A human-readable message describing the result of the operation. |
| `Data` | [`List<ExerciseMetric>`](../../doc/models/exercise-metric.md) | Required | The data returned by the operation. |

## Example (as JSON)

```json
{
  "status": "OK",
  "message": "Operation completed successfully.",
  "data": [
    {
      "exerciseMetricCode": "WEIGHT",
      "exerciseMetricName": "exerciseMetricName0",
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
  ]
}
```

