
# Creator Profiles 401 Error Exception

## Structure

`CreatorProfiles401ErrorException`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `string` | Required | - |
| `Message` | `string` | Required | - |
| `Errors` | `List<string>` | Optional | - |

## Example (as JSON)

```json
{
  "status": "Unauthorized",
  "message": "Authentication required",
  "errors": [
    "User not authenticated"
  ]
}
```

