
# Programs Reviews 404 Error Exception

## Structure

`ProgramsReviews404ErrorException`

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
  "message": "Program not found",
  "errors": [
    "Program with the specified ID does not exist"
  ]
}
```

