
# Exercise Categories 400 Error Exception

## Structure

`ExerciseCategories400ErrorException`

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
  "message": "Invalid exercise category data",
  "errors": [
    "Category code is required"
  ]
}
```

