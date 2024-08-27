
# Workouts Data 400 Error Exception

## Structure

`WorkoutsData400ErrorException`

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
  "message": "Invalid exercise data",
  "errors": [
    "Invalid exercise data provided"
  ]
}
```

