
# Exercises Response 2

## Structure

`ExercisesResponse2`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `string` | Required | - |
| `Message` | `string` | Required | - |
| `Data` | [`Exercise`](../../doc/models/exercise.md) | Optional | - |

## Example (as JSON)

```json
{
  "status": "OK",
  "message": "Exercise retrieved successfully",
  "data": {
    "exerciseCode": "exerciseCode2",
    "exerciseName": "exerciseName2",
    "exerciseTranslations": [
      {
        "localeCode": "localeCode0",
        "exerciseName": "exerciseName0",
        "isPrimary": false
      }
    ],
    "exerciseEquipment": {
      "required": [
        "required2",
        "required3",
        "required4"
      ],
      "optional": [
        "optional3"
      ]
    },
    "exerciseMuscles": [
      {
        "muscleCode": "muscleCode6",
        "targetPercentage": 202,
        "isPrimary": false
      }
    ]
  }
}
```

