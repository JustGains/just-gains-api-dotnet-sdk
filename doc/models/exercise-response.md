
# Exercise Response

## Structure

`ExerciseResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `string` | Required | The status of the response, corresponding to standard HTTP status codes. |
| `Message` | `string` | Required | A human-readable message describing the result of the operation. |
| `Data` | [`Exercise1`](../../doc/models/exercise-1.md) | Required | The data returned by the operation. |

## Example (as JSON)

```json
{
  "status": "OK",
  "message": "Operation completed successfully.",
  "data": {
    "exerciseCode": "BARBELL_SQUAT",
    "exerciseName": "Barbell Squat",
    "userId": "123e4567-e89b-12d3-a456-426614174000",
    "exerciseTypeCode": "STRENGTH",
    "publishStatusCode": "UNREVIEWED",
    "difficulty": 7,
    "metabolicEquivalent": 8.5,
    "isPlateloaded": true,
    "isCardio": false,
    "olympicRating": 5,
    "powerLifterRating": 5,
    "calisthenicRating": 5,
    "popularityRating": 5,
    "isPlyometric": true,
    "isIsometric": false,
    "isCalisthenic": true,
    "isWeighted": false,
    "isUnilateral": true,
    "isBodyweight": true,
    "adminNotes": "This exercise requires supervision.",
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

