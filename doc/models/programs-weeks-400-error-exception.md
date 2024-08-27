
# Programs Weeks 400 Error Exception

## Structure

`ProgramsWeeks400ErrorException`

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
  "message": "Failed to add week",
  "errors": [
    "Invalid week data"
  ]
}
```

