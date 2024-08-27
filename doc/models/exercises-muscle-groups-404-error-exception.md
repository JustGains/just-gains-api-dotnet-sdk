
# Exercises Muscle Groups 404 Error Exception

## Structure

`ExercisesMuscleGroups404ErrorException`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `string` | Required | - |
| `Message` | `string` | Required | - |
| `Errors` | `List<string>` | Optional | - |

## Example (as JSON)

```json
{
  "status": "Not Found",
  "message": "Exercise not found",
  "errors": [
    "No exercise found with the specified code"
  ]
}
```

