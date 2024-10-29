
# O Auth Settings

OAuth provider settings

## Structure

`OAuthSettings`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `string` | Required | The status of the response, corresponding to standard HTTP status codes. |
| `Message` | `string` | Required | A human-readable message describing the result of the operation. |
| `Data` | [`Data4`](../../doc/models/data-4.md) | Required | - |

## Example (as JSON)

```json
{
  "status": "OK",
  "message": "Operation completed successfully.",
  "data": {
    "clientId": "clientId4",
    "authorizeUrl": "authorizeUrl6",
    "tokenUrl": "tokenUrl0",
    "scopes": [
      "scopes6",
      "scopes5"
    ]
  }
}
```

