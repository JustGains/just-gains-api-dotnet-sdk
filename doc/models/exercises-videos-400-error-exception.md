
# Exercises Videos 400 Error Exception

## Structure

`ExercisesVideos400ErrorException`

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
  "message": "Invalid exercise code",
  "errors": [
    "Invalid exercise code provided"
  ]
}
```

