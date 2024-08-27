
# Exercises Videos 401 Error Exception

## Structure

`ExercisesVideos401ErrorException`

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
  "message": "Authentication required",
  "errors": [
    "User is not authenticated"
  ]
}
```

