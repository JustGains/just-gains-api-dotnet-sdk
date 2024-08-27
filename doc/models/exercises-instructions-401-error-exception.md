
# Exercises Instructions 401 Error Exception

## Structure

`ExercisesInstructions401ErrorException`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `string` | Required | - |
| `Message` | `string` | Required | - |
| `Errors` | `List<string>` | Optional | - |

## Example (as JSON)

```json
{
  "status": "Unauthorized",
  "message": "Unauthorized",
  "errors": [
    "User not authenticated"
  ]
}
```

