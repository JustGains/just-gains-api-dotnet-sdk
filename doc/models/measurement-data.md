
# Measurement Data

## Structure

`MeasurementData`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `MetricCode` | `string` | Optional | - |
| `DisplayName` | `string` | Optional | - |
| `Units` | [`Units`](../../doc/models/units.md) | Optional | - |
| `DisplayFormat` | `string` | Optional | - |
| `InputType` | `string` | Optional | - |
| `Step` | `double?` | Optional | - |
| `MinValue` | `double?` | Optional | - |
| `MaxValue` | `double?` | Optional | - |
| `DefaultValue` | `double?` | Optional | - |
| `ConversionFactor` | [`ConversionFactor`](../../doc/models/conversion-factor.md) | Optional | - |

## Example (as JSON)

```json
{
  "metricCode": "WEIGHT",
  "displayName": "Weight",
  "displayFormat": "{value} {unit}",
  "inputType": "numeric",
  "step": 0.1,
  "minValue": 0,
  "maxValue": 1000,
  "defaultValue": 0,
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
  }
}
```

