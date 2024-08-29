
# Just Gains Error Response Exception

## Structure

`JustGainsErrorResponseException`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `string` | Required | The status of the response, corresponding to standard HTTP status codes. |
| `Message` | `string` | Required | A human-readable message describing the result of the operation. |
| `Errors` | `List<string>` | Optional | A list of error messages that occurred during the operation. |

## Example (as JSON)

```json
{
  "status": "Error",
  "message": "Operation Failed",
  "errors": [
    "Invalid input data",
    "User not found"
  ]
}
```

