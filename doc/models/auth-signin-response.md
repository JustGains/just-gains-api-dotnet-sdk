
# Auth Signin Response

## Structure

`AuthSigninResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `string` | Required | The status of the response, corresponding to standard HTTP status codes. |
| `Message` | `string` | Required | A human-readable message describing the result of the operation. |
| `Data` | [`Data1`](../../doc/models/data-1.md) | Required | - |

## Example (as JSON)

```json
{
  "status": "OK",
  "message": "Operation completed successfully.",
  "data": {
    "accessToken": "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9...",
    "refreshToken": "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9...",
    "tokenExpiration": "06/15/2023 14:30:00",
    "userInfo": {
      "id": "00000bce-0000-0000-0000-000000000000",
      "email": "email4",
      "userName": "userName4",
      "firstName": "firstName2",
      "lastName": "lastName6"
    }
  }
}
```

