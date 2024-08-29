
# Programs 400 Error Exception

## Structure

`Programs400ErrorException`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `string` | Required | The status of the response, corresponding to standard HTTP status codes. |
| `Message` | `string` | Required | A human-readable message describing the result of the operation. |
| `Data` | `object` | Required | The data returned by the operation. |
| `Errors` | `object` | Optional | - |

## Example (as JSON)

```json
{
  "status": "OK",
  "message": "Operation completed successfully.",
  "data": {
    "key1": "val1",
    "key2": "val2"
  },
  "errors": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

