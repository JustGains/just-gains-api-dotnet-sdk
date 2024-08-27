
# Creator Profiles 500 Error Exception

## Structure

`CreatorProfiles500ErrorException`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `string` | Required | - |
| `Message` | `string` | Required | - |
| `Errors` | `List<string>` | Optional | - |

## Example (as JSON)

```json
{
  "status": "Internal Server Error",
  "message": "An unexpected error occurred",
  "errors": [
    "Internal server error"
  ]
}
```

