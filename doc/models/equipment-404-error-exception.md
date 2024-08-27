
# Equipment 404 Error Exception

## Structure

`Equipment404ErrorException`

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
  "message": "Equipment not found",
  "errors": [
    "Equipment with the specified code does not exist"
  ]
}
```

