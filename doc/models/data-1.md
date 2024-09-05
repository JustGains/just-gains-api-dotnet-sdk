
# Data 1

## Structure

`Data1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccessToken` | `string` | Optional | JWT access token for authenticated requests |
| `RefreshToken` | `string` | Optional | JWT refresh token for obtaining new access tokens |
| `TokenExpiration` | `DateTime?` | Optional | Expiration time of the access token |
| `UserInfo` | [`UserInfo`](../../doc/models/user-info.md) | Optional | User information object |

## Example (as JSON)

```json
{
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
```

