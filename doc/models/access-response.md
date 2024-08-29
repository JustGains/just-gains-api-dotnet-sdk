
# Access Response

## Structure

`AccessResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccessToken` | `string` | Optional | JWT access token for authenticated requests |
| `RefreshToken` | `string` | Optional | JWT refresh token for obtaining new access tokens |
| `TokenExpiration` | `DateTime?` | Optional | Expiration time of the access token |

## Example (as JSON)

```json
{
  "accessToken": "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9...",
  "refreshToken": "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9...",
  "tokenExpiration": "06/15/2023 14:30:00"
}
```

