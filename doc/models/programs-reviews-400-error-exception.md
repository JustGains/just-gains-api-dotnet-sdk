
# Programs Reviews 400 Error Exception

## Structure

`ProgramsReviews400ErrorException`

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
  "message": "Failed to add review",
  "errors": [
    "Invalid review data"
  ]
}
```

