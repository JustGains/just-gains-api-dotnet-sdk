
# Exercises 400 Error Exception

## Structure

`Exercises400ErrorException`

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
  "message": "Failed to get exercises",
  "errors": [
    "Invalid filter parameters"
  ]
}
```

