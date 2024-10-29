
# O Auth State Response

Response object for OAuth state

## Structure

`OAuthStateResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `string` | Required | The status of the response, corresponding to standard HTTP status codes. |
| `Message` | `string` | Required | A human-readable message describing the result of the operation. |
| `Data` | [`Data2`](../../doc/models/data-2.md) | Required | - |

## Example (as JSON)

```json
{
  "status": "OK",
  "message": "Operation completed successfully.",
  "data": {
    "uri": "https://oauth-provider.com/auth?client_id=123&redirect_uri=...",
    "pkceVerifier": "dBjftJeZ4CVP-mB92K27uhbUJU1p1r_wW1gFWFOEjXk"
  }
}
```

