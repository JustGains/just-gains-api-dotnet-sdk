
# O Auth Callback Response

Response object for OAuth callback

## Structure

`OAuthCallbackResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `string` | Required | The status of the response, corresponding to standard HTTP status codes. |
| `Message` | `string` | Required | A human-readable message describing the result of the operation. |
| `Data` | [`Data3`](../../doc/models/data-3.md) | Required | - |

## Example (as JSON)

```json
{
  "status": "OK",
  "message": "Operation completed successfully.",
  "data": {
    "accessToken": "accessToken8",
    "refreshToken": "refreshToken8",
    "user": {
      "id": "0000143c-0000-0000-0000-000000000000",
      "email": "email6",
      "userName": "userName2",
      "firstName": "firstName4",
      "lastName": "lastName4"
    }
  }
}
```

