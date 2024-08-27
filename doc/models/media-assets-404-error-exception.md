
# Media Assets 404 Error Exception

## Structure

`MediaAssets404ErrorException`

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
  "message": "Media asset not found",
  "errors": [
    "The requested media asset could not be found"
  ]
}
```

