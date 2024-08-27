
# Exercises Instructions 404 Error Exception

## Structure

`ExercisesInstructions404ErrorException`

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
  "message": "Exercise instructions not found",
  "errors": [
    "No instructions found for the specified exercise code"
  ]
}
```

