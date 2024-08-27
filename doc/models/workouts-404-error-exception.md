
# Workouts 404 Error Exception

## Structure

`Workouts404ErrorException`

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
  "message": "Workout not found",
  "errors": [
    "The requested workout could not be found"
  ]
}
```

