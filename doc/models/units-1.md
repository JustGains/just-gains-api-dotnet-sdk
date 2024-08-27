
# Units 1

## Structure

`Units1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `UnitCode` | `string` | Optional | - |
| `UnitShort` | [`UnitShort`](../../doc/models/unit-short.md) | Optional | - |
| `UnitLong` | [`UnitLong`](../../doc/models/unit-long.md) | Optional | - |
| `ConversionFactor` | `double?` | Optional | - |

## Example (as JSON)

```json
{
  "unitCode": "KG",
  "conversionFactor": 1.0,
  "unitShort": {
    "unitShortName": "unitShortName4",
    "unitShortPlural": "unitShortPlural8"
  },
  "unitLong": {
    "unitLongName": "unitLongName4",
    "unitLongPlural": "unitLongPlural6"
  }
}
```

