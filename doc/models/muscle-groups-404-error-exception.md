
# Muscle Groups 404 Error Exception

## Structure

`MuscleGroups404ErrorException`

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
  "message": "Muscle group not found",
  "errors": [
    "The requested muscle group could not be found"
  ]
}
```

