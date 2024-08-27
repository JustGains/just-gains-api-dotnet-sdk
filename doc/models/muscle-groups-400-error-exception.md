
# Muscle Groups 400 Error Exception

## Structure

`MuscleGroups400ErrorException`

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
  "message": "Invalid muscle group data",
  "errors": [
    "Invalid muscle group code format"
  ]
}
```

