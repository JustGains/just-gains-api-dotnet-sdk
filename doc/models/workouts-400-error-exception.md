
# Workouts 400 Error Exception

## Structure

`Workouts400ErrorException`

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
  "message": "Invalid pagination parameters",
  "errors": [
    "Invalid page number",
    "Invalid page size"
  ]
}
```

