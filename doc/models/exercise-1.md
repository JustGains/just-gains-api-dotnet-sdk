
# Exercise 1

The data returned by the operation.

## Structure

`Exercise1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ExerciseCode` | `string` | Optional | A unique identifier for the exercise. |
| `ExerciseName` | `string` | Optional | Translated Primary Exercise Name |
| `ExerciseTranslations` | [`List<ExerciseTranslation>`](../../doc/models/exercise-translation.md) | Optional | - |
| `ExerciseEquipment` | [`ExerciseEquipment`](../../doc/models/exercise-equipment.md) | Optional | - |
| `ExerciseMuscles` | [`List<ExerciseMuscle>`](../../doc/models/exercise-muscle.md) | Optional | - |
| `ExerciseVideos` | [`List<ExerciseVideo>`](../../doc/models/exercise-video.md) | Optional | - |
| `ExerciseInstructions` | [`List<ExerciseInstruction>`](../../doc/models/exercise-instruction.md) | Optional | - |
| `ExerciseThumbnail` | [`MediaAsset`](../../doc/models/media-asset.md) | Optional | - |
| `UserId` | `Guid?` | Optional | The user ID of the user who created the exercise. |
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
    },
    {
      "localeCode": "localeCode0",
      "exerciseName": "exerciseName0",
      "isPrimary": false
    },
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
    },
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

