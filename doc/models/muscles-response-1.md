
# Muscles Response 1

## Structure

`MusclesResponse1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `string` | Required | - |
| `Message` | `string` | Required | - |
| `Data` | [`Data25`](../../doc/models/data-25.md) | Optional | - |

## Example (as JSON)

```json
{
  "status": "OK",
  "message": "Muscle retrieved successfully",
  "data": {
    "muscleCode": "muscleCode0",
    "muscleName": "muscleName2",
    "muscleTranslations": [
      {
        "muscleCode": "muscleCode2",
        "localeCode": "localeCode4",
        "muscleName": "muscleName4"
      },
      {
        "muscleCode": "muscleCode2",
        "localeCode": "localeCode4",
        "muscleName": "muscleName4"
      }
    ]
  }
}
```

