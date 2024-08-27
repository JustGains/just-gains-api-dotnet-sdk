
# Muscles Response

## Structure

`MusclesResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `string` | Required | - |
| `Message` | `string` | Required | - |
| `Data` | [`List<Muscle>`](../../doc/models/muscle.md) | Optional | - |

## Example (as JSON)

```json
{
  "status": "OK",
  "message": "Muscles retrieved successfully",
  "data": [
    {
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
  ]
}
```

