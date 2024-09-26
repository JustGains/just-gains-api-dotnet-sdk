
# Exercise Update Request

## Structure

`ExerciseUpdateRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ExerciseCode` | `string` | Optional | A unique identifier for the exercise. |
| `ExerciseName` | `string` | Optional | Translated Primary Exercise Name |
| `ExerciseEquipment` | [`ExerciseEquipment`](../../doc/models/exercise-equipment.md) | Optional | - |
| `ExerciseMuscles` | [`List<ExerciseMuscle>`](../../doc/models/exercise-muscle.md) | Optional | - |
| `ExerciseCategories` | `List<string>` | Optional | Array of category codes associated with this exercise |
| `ExerciseTypeCode` | `string` | Optional | The exerciseTypeCode of the exercise |
| `PublishStatusCode` | [`PublishStatusCodeEnum?`](../../doc/models/publish-status-code-enum.md) | Optional | The publish status of the exercise |
| `Difficulty` | `int?` | Optional | Difficulty level of the exercise |
| `MetabolicEquivalent` | `double?` | Optional | Metabolic equivalent of the exercise |
| `IsPlateloaded` | `bool?` | Optional | Indicates if the exercise is plateloaded |
| `IsCardio` | `bool?` | Optional | Indicates if the exercise is cardio |
| `OlympicRating` | `int?` | Optional | Olympic rating of the exercise<br>**Default**: `0`<br>**Constraints**: `>= 0`, `<= 5` |
| `PowerLifterRating` | `int?` | Optional | Power lifter rating of the exercise<br>**Default**: `0`<br>**Constraints**: `>= 0`, `<= 5` |
| `CalisthenicRating` | `int?` | Optional | Calisthenic rating of the exercise<br>**Default**: `0`<br>**Constraints**: `>= 0`, `<= 5` |
| `PopularityRating` | `int?` | Optional | Popularity rating of the exercise<br>**Default**: `0`<br>**Constraints**: `>= 0`, `<= 5` |
| `IsPlyometric` | `bool?` | Optional | Indicates if the exercise is plyometric |
| `IsIsometric` | `bool?` | Optional | Indicates if the exercise is isometric |
| `IsCalisthenic` | `bool?` | Optional | Indicates if the exercise is calisthenic |
| `IsWeighted` | `bool?` | Optional | Indicates if the exercise is weighted |
| `IsUnilateral` | `bool?` | Optional | Indicates if the exercise is unilateral |
| `IsBodyweight` | `bool?` | Optional | Indicates if the exercise is bodyweight |
| `AdminNotes` | `string` | Optional | Admin notes for the exercise |

## Example (as JSON)

```json
{
  "exerciseCode": "BARBELL_SQUAT",
  "exerciseName": "Barbell Squat",
  "exerciseCategories": [
    "STRENGTH",
    "CARDIO"
  ],
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
  "exerciseEquipment": {
    "required": [
      [
        "required2",
        "required3",
        "required4"
      ],
      [
        "required2",
        "required3",
        "required4"
      ],
      [
        "required2",
        "required3",
        "required4"
      ]
    ],
    "optional": [
      [
        "optional3"
      ]
    ]
  },
  "exerciseMuscles": [
    {
      "muscleCode": "muscleCode6",
      "targetPercentage": 202,
      "isPrimary": false
    },
    {
      "muscleCode": "muscleCode6",
      "targetPercentage": 202,
      "isPrimary": false
    }
  ]
}
```

