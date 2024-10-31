
# Auth Response

Response object for authentication operations

## Structure

`AuthResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`AuthData`](../../doc/models/auth-data.md) | Optional | Authentication data containing tokens and user information |

## Example (as JSON)

```json
{
  "data": {
    "accessToken": "accessToken8",
    "refreshToken": "refreshToken8",
    "tokenExpiration": "tokenExpiration4",
    "userInfo": {
      "userId": "0000084a-0000-0000-0000-000000000000",
      "userName": "userName4",
      "emailConfirmed": false,
      "email": "email4",
      "password": "password6"
    }
  }
}
```

