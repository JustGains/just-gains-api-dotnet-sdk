
# Published Status Translations 401 Error Exception

## Structure

`PublishedStatusTranslations401ErrorException`

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
    "Valid authentication credentials are required to access this resource"
  ]
}
```

