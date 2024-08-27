
# Exercise Categories Response 1

## Structure

`ExerciseCategoriesResponse1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `string` | Required | - |
| `Message` | `string` | Required | - |
| `Data` | [`Data38`](../../doc/models/data-38.md) | Optional | - |

## Example (as JSON)

```json
{
  "status": "Created",
  "message": "Exercise category created successfully",
  "data": {
    "exerciseCategoryCode": "exerciseCategoryCode8",
    "exerciseCategoryName": "exerciseCategoryName2"
  }
}
```

