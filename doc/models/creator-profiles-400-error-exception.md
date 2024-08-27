
# Creator Profiles 400 Error Exception

## Structure

`CreatorProfiles400ErrorException`

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
  "message": "Invalid request parameters",
  "errors": [
    "Invalid page number"
  ]
}
```

