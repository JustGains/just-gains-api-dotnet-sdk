
# Exercise Metrics 404 Error Exception

## Structure

`ExerciseMetrics404ErrorException`

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
  "message": "Exercise metric not found",
  "errors": [
    "Exercise metric with the specified code does not exist"
  ]
}
```

