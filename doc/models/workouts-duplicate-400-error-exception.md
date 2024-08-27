
# Workouts Duplicate 400 Error Exception

## Structure

`WorkoutsDuplicate400ErrorException`

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
  "message": "Invalid contribution type",
  "errors": [
    "INVALID_CONTRIBUTION_TYPE"
  ]
}
```

