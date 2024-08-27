
# Exercises Translations Response

## Structure

`ExercisesTranslationsResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `string` | Required | - |
| `Message` | `string` | Required | - |
| `Data` | [`List<ExerciseTranslation>`](../../doc/models/exercise-translation.md) | Optional | - |

## Example (as JSON)

```json
{
  "status": "OK",
  "message": "Exercise translations retrieved successfully",
  "data": [
    {
      "localeCode": "localeCode2",
      "exerciseName": "exerciseName2",
      "isPrimary": false
    },
    {
      "localeCode": "localeCode2",
      "exerciseName": "exerciseName2",
      "isPrimary": false
    }
  ]
}
```

