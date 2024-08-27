
# Creator Profiles 404 Error Exception

## Structure

`CreatorProfiles404ErrorException`

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
  "message": "Creator profile not found",
  "errors": [
    "The requested creator profile does not exist"
  ]
}
```

