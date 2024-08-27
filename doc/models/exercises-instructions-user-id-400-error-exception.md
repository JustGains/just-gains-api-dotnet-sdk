
# Exercises Instructions User Id 400 Error Exception

## Structure

`ExercisesInstructionsUserId400ErrorException`

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
  "message": "Invalid request",
  "errors": [
    "Invalid exercise code"
  ]
}
```

