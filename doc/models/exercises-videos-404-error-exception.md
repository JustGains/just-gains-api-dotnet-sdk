
# Exercises Videos 404 Error Exception

## Structure

`ExercisesVideos404ErrorException`

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
  "message": "Exercise videos not found",
  "errors": [
    "No videos found for the specified exercise code"
  ]
}
```

