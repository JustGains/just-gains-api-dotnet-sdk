
# Muscles 400 Error Exception

## Structure

`Muscles400ErrorException`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `string` | Required | The status of the response, corresponding to standard HTTP status codes. |
| `Message` | `string` | Required | A human-readable message describing the result of the operation. |
| `Errors` | `List<string>` | Optional | A list of error messages that occurred during the operation. |
| `Error` | `object` | Optional | - |

## Example (as JSON)

```json
{
  "status": "status6",
  "message": "message4",
  "errors": [
    "errors9",
    "errors0"
  ],
  "error": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

