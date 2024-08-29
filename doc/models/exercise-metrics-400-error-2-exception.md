
# Exercise Metrics 400 Error 2 Exception

## Structure

`ExerciseMetrics400Error2Exception`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `string` | Required | The status of the response, corresponding to standard HTTP status codes. |
| `Message` | `string` | Required | A human-readable message describing the result of the operation. |
| `Errors` | `object` | Optional | - |

## Example (as JSON)

```json
{
  "status": "OK",
  "message": "Operation completed successfully.",
  "errors": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

