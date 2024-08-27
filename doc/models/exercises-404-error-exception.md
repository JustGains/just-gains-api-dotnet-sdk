
# Exercises 404 Error Exception

## Structure

`Exercises404ErrorException`

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
  "message": "Exercise not found",
  "errors": [
    "Exercise with the specified code does not exist"
  ]
}
```

