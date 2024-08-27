
# Exercise Categories Response

## Structure

`ExerciseCategoriesResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `string` | Required | - |
| `Message` | `string` | Required | - |
| `Data` | [`List<ExerciseCategory>`](../../doc/models/exercise-category.md) | Optional | - |

## Example (as JSON)

```json
{
  "status": "OK",
  "message": "Exercise categories retrieved successfully",
  "data": [
    {
      "exerciseCategoryCode": "exerciseCategoryCode8",
      "exerciseCategoryName": "exerciseCategoryName2"
    }
  ]
}
```

