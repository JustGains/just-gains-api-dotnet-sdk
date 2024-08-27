
# Exercises Muscle Groups 400 Error Exception

## Structure

`ExercisesMuscleGroups400ErrorException`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `string` | Required | - |
| `Message` | `string` | Required | - |
| `Errors` | `List<string>` | Optional | - |

## Example (as JSON)

```json
{
  "status": "Bad Request",
  "message": "Invalid request parameters",
  "errors": [
    "Invalid exercise code",
    "Invalid locale code"
  ]
}
```

