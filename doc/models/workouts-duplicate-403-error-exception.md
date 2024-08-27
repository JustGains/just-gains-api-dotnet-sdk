
# Workouts Duplicate 403 Error Exception

## Structure

`WorkoutsDuplicate403ErrorException`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `string` | Required | - |
| `Message` | `string` | Required | - |
| `Errors` | `List<string>` | Optional | - |

## Example (as JSON)

```json
{
  "status": "Forbidden",
  "message": "You don't have permission to duplicate this workout",
  "errors": [
    "DUPLICATE_PERMISSION_DENIED"
  ]
}
```

