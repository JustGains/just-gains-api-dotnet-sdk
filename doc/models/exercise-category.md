
# Exercise Category

Represents a category for exercises, including its code and translations.

## Structure

`ExerciseCategory`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ExerciseCategoryCode` | `string` | Optional | Unique identifier for the exercise category. |
| `ExerciseCategoryName` | `string` | Optional | The name of the exercise category in the default language (typically English). This is a read-only field derived from translations. |

## Example (as JSON)

```json
{
  "exerciseCategoryCode": "STRENGTH_TRAINING",
  "exerciseCategoryName": "Strength Training"
}
```

